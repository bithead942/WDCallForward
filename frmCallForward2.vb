Public Class frmCallForward

    Friend WithEvents Event_HistoryTableAdapter As New WatchdogDataSetTableAdapters.Event_HistoryTableAdapter
    Dim strCOMPort As String = "COM4"
    Dim comPort As IO.Ports.SerialPort

    Private Sub frmCallForward_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim FILE_NAME As String = "WDCallForwardParameter.xml"

        Dim objWriter As New System.IO.StreamWriter(FILE_NAME)

        objWriter.Write("<Parameter><PhoneNo>" & txtForwardNo.Text & "</PhoneNo></Parameter>")
        objWriter.Close()

        Event_HistoryTableAdapter.InsertQuery("9022", Now)
    End Sub

    Private Sub frmCallForward_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim iConnectStringLen As Integer
        Dim xmlData As DataSet = New DataSet()

        Try
            xmlData.ReadXml("WDCallForwardParameter.xml")
            txtForwardNo.Text = xmlData.Tables(0).Rows(0).ItemArray(0)
        Catch ex As Exception
            'ignore
        End Try

        Try
            iConnectStringLen = Event_Current_StateTableAdapter.Connection.ConnectionString.Length
            Event_Current_StateTableAdapter.Connection.ConnectionString = Event_Current_StateTableAdapter.Connection.ConnectionString.Insert(iConnectStringLen, ";password=lEEward1")
            iConnectStringLen = Event_HistoryTableAdapter.Connection.ConnectionString.Length
            Event_HistoryTableAdapter.Connection.ConnectionString = Event_HistoryTableAdapter.Connection.ConnectionString.Insert(iConnectStringLen, ";password=lEEward1")

            Event_HistoryTableAdapter.InsertQuery("9021", Now)


            comPort = Nothing
            comPort = My.Computer.Ports.OpenSerialPort(strCOMPort, 9600)
            comPort.Write("ATM0")   'turn off speaker
            Thread.Sleep(2000)
            comPort.DtrEnable = True

            Me.Event_Current_StateTableAdapter.Fill(Me.WatchdogDataSet.Event_Current_State)
            If WatchdogDataSet.Event_Current_State.Rows(1).Item(1).ToString = "1" Then
                lblOccupied.Text = "Yes"
            Else
                lblOccupied.Text = "No"
            End If
            lblLastChecked.Text = Now.ToString
            tCheckHouseOccupied.Start()
            btnStart.Enabled = False
            btnStop.Enabled = True
        Catch ex As Exception
            Event_HistoryTableAdapter.InsertQuery("9930", Now)
            End
        End Try

    End Sub

    Private Sub btnActivate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActivate.Click
        tCheckHouseOccupied.Stop()
        btnDeactivate.Enabled = False
        btnActivate.Enabled = False

        CFActivate()

        btnDeactivate.Enabled = True
        btnActivate.Enabled = True
        tCheckHouseOccupied.Start()
    End Sub

    Private Sub btnDeactivate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeactivate.Click
        tCheckHouseOccupied.Stop()
        btnDeactivate.Enabled = False
        btnActivate.Enabled = False

        CFDeactivate()

        btnDeactivate.Enabled = True
        btnActivate.Enabled = True
        tCheckHouseOccupied.Start()
    End Sub

    Private Sub CFActivate()
        Try
            comPort.Write("ATDT *72," & txtForwardNo.Text & vbCrLf)
            'Thread.Sleep(9000)
            Thread.Sleep(9500)
            comPort.Write("ATH" & vbCrLf)
            'Thread.Sleep(5000)
            Thread.Sleep(9500)
            comPort.Write("ATDT *72," & txtForwardNo.Text & vbCrLf)
            'Thread.Sleep(9000)
            Thread.Sleep(9500)
            comPort.Write("ATH" & vbCrLf)
            Thread.Sleep(2000)
            lblStatus.Text = "Forwarded"
            lblLastActivated.Text = Now.ToString
            Event_HistoryTableAdapter.InsertQuery("5050", Now)
            DeleteRingEvents()
        Catch ex As Exception
            Event_HistoryTableAdapter.InsertQuery("9930", Now)
        End Try


    End Sub

    Private Sub CFDeactivate()
        Try
            comPort.Write("ATDT *73,," & vbCrLf)
            Thread.Sleep(6000)
            comPort.Write("ATH" & vbCrLf)
            Thread.Sleep(3000)
            lblStatus.Text = "Not Forwarded"
            Event_HistoryTableAdapter.InsertQuery("5051", Now)
            DeleteRingEvents()
        Catch ex As Exception
            Event_HistoryTableAdapter.InsertQuery("9930", Now)
        End Try
    End Sub

    Private Sub DeleteRingEvents()
        Dim Event_History_DB As WatchdogDataSet.Event_HistoryDataTable
        Dim i As Integer

        'Check last 2 event logs.  Delete telephone rings (5004) if exists
        Event_History_DB = Event_HistoryTableAdapter.GetLast3()
        For i = 1 To 2
            If Event_History_DB.Rows(i).Item(0).ToString = "5004" Then
                Event_HistoryTableAdapter.DeletePhoneLog(Event_History_DB.Rows(i).Item(0).ToString, Event_History_DB.Rows(i).Item(1).ToString)
            End If
        Next i
    End Sub

    Private Sub tCheckHouseOccupied_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tCheckHouseOccupied.Tick
        Dim strOccupiedState As String

        Try
            tCheckHouseOccupied.Stop()
            Me.Event_Current_StateTableAdapter.Fill(Me.WatchdogDataSet.Event_Current_State)

            strOccupiedState = WatchdogDataSet.Event_Current_State.Rows(1).Item(1).ToString

            If strOccupiedState = "1" And lblOccupied.Text = "No" Then    'Just got home
                CFDeactivate()
                lblOccupied.Text = "Yes"
            ElseIf strOccupiedState = "0" And lblOccupied.Text = "Yes" Then   'Just left
                CFActivate()
                lblOccupied.Text = "No"
            End If

            lblLastChecked.Text = Now.ToString
            tCheckHouseOccupied.Start()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        tCheckHouseOccupied.Start()
        btnStart.Enabled = False
        btnStop.Enabled = True
    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        tCheckHouseOccupied.Stop()
        btnStop.Enabled = False
        btnStart.Enabled = True
    End Sub
End Class
