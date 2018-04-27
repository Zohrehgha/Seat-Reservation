Public Class Form1
    'Dim businessSeat(2, 10) As Boolean
    'Dim economicSeat(31, 10) As Boolean
    Dim i As Integer
    Dim j As Integer
    Dim seatTag As String    'name of every seat that choose
    'Define two dimentional array for Business and Economy seats number 
    Private Sub FreeSeats()

        For i = 0 To 1
            seatTag = "PictureBox" & (i) & (j) & "B"
            For j = 0 To 9
                'businessSeat(i, j) = False
                seatTag = "PictureBox" & (i) & (j) & "B"
                ListBox1.Items.Add(seatTag)   'adding all free Business seat in that list
                ListBox1.Items.Remove("PictureBox00B")
            Next
        Next
        ListBox1.Items.Add("PictureBox20B")
        For i = 2 To 31
            seatTag = "PictureBox" & (i) & (j)
            For j = 0 To 9
                'economicSeat(i, j) = False
                seatTag = "PictureBox" & (i) & (j)
                ListBox1.Items.Add(seatTag)   ''adding all free Economy seat in that list
            Next
        Next
        ListBox1.Items.Add("PictureBox320")
    End Sub
    'With form load call Freeseat 
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FreeSeats()
    End Sub
    Private Sub seatClicked(sender As Object, e As EventArgs) Handles PictureBox99.Click, PictureBox98.Click, PictureBox97.Click, PictureBox96.Click, PictureBox95.Click, PictureBox94.Click, PictureBox93.Click, PictureBox92.Click, PictureBox91.Click, PictureBox90.Click, PictureBox09B.Click, PictureBox89.Click, PictureBox88.Click, PictureBox87.Click, PictureBox86.Click, PictureBox85.Click, PictureBox84.Click, PictureBox83.Click, PictureBox82.Click, PictureBox81.Click, PictureBox80.Click, PictureBox08B.Click, PictureBox79.Click, PictureBox78.Click, PictureBox77.Click, PictureBox76.Click, PictureBox75.Click, PictureBox74.Click, PictureBox73.Click, PictureBox72.Click, PictureBox71.Click, PictureBox70.Click, PictureBox07B.Click, PictureBox69.Click, PictureBox68.Click, PictureBox67.Click, PictureBox66.Click, PictureBox65.Click, PictureBox64.Click, PictureBox63.Click, PictureBox62.Click, PictureBox61.Click, PictureBox60.Click, PictureBox06B.Click, PictureBox59.Click, PictureBox58.Click, PictureBox57.Click, PictureBox56.Click, PictureBox55.Click, PictureBox54.Click, PictureBox53.Click, PictureBox52.Click, PictureBox51.Click, PictureBox50.Click, PictureBox05B.Click, PictureBox49.Click, PictureBox48.Click, PictureBox47.Click, PictureBox46.Click, PictureBox45.Click, PictureBox44.Click, PictureBox43.Click, PictureBox42.Click, PictureBox41.Click, PictureBox40.Click, PictureBox04B.Click, PictureBox39.Click, PictureBox38.Click, PictureBox37.Click, PictureBox36.Click, PictureBox35.Click, PictureBox34.Click, PictureBox33.Click, PictureBox320.Click, PictureBox32.Click, PictureBox319.Click, PictureBox318.Click, PictureBox317.Click, PictureBox316.Click, PictureBox315.Click, PictureBox314.Click, PictureBox313.Click, PictureBox312.Click, PictureBox311.Click, PictureBox310.Click, PictureBox31.Click, PictureBox309.Click, PictureBox308.Click, PictureBox307.Click, PictureBox306.Click, PictureBox305.Click, PictureBox304.Click, PictureBox303.Click, PictureBox302.Click, PictureBox301.Click, PictureBox300.Click, PictureBox30.Click, PictureBox03B.Click, PictureBox299.Click, PictureBox298.Click, PictureBox297.Click, PictureBox296.Click, PictureBox295.Click, PictureBox294.Click, PictureBox293.Click, PictureBox292.Click, PictureBox291.Click, PictureBox290.Click, PictureBox29.Click, PictureBox289.Click, PictureBox288.Click, PictureBox287.Click, PictureBox286.Click, PictureBox285.Click, PictureBox284.Click, PictureBox283.Click, PictureBox282.Click, PictureBox281.Click, PictureBox280.Click, PictureBox28.Click, PictureBox279.Click, PictureBox278.Click, PictureBox277.Click, PictureBox276.Click, PictureBox275.Click, PictureBox274.Click, PictureBox273.Click, PictureBox272.Click, PictureBox271.Click, PictureBox270.Click, PictureBox27.Click, PictureBox269.Click, PictureBox268.Click, PictureBox267.Click, PictureBox266.Click, PictureBox265.Click, PictureBox264.Click, PictureBox263.Click, PictureBox262.Click, PictureBox261.Click, PictureBox260.Click, PictureBox26.Click, PictureBox259.Click, PictureBox258.Click, PictureBox257.Click, PictureBox256.Click, PictureBox255.Click, PictureBox254.Click, PictureBox253.Click, PictureBox252.Click, PictureBox251.Click, PictureBox250.Click, PictureBox25.Click, PictureBox249.Click, PictureBox248.Click, PictureBox247.Click, PictureBox246.Click, PictureBox245.Click, PictureBox244.Click, PictureBox243.Click, PictureBox242.Click, PictureBox241.Click, PictureBox240.Click, PictureBox24.Click, PictureBox239.Click, PictureBox238.Click, PictureBox237.Click, PictureBox236.Click, PictureBox235.Click, PictureBox234.Click, PictureBox233.Click, PictureBox232.Click, PictureBox231.Click, PictureBox230.Click, PictureBox23.Click, PictureBox229.Click, PictureBox228.Click, PictureBox227.Click, PictureBox226.Click, PictureBox225.Click, PictureBox224.Click, PictureBox223.Click, PictureBox222.Click, PictureBox221.Click, PictureBox220.Click, PictureBox22.Click, PictureBox219.Click, PictureBox218.Click, PictureBox217.Click, PictureBox216.Click, PictureBox215.Click, PictureBox214.Click, PictureBox213.Click, PictureBox212.Click, PictureBox211.Click, PictureBox210.Click, PictureBox21.Click, PictureBox209.Click, PictureBox208.Click, PictureBox207.Click, PictureBox206.Click, PictureBox205.Click, PictureBox204.Click, PictureBox203.Click, PictureBox202.Click, PictureBox201.Click, PictureBox200.Click, PictureBox20B.Click, PictureBox02B.Click, PictureBox199.Click, PictureBox198.Click, PictureBox197.Click, PictureBox196.Click, PictureBox195.Click, PictureBox194.Click, PictureBox193.Click, PictureBox192.Click, PictureBox191.Click, PictureBox190.Click, PictureBox19B.Click, PictureBox189.Click, PictureBox188.Click, PictureBox187.Click, PictureBox186.Click, PictureBox185.Click, PictureBox184.Click, PictureBox183.Click, PictureBox182.Click, PictureBox181.Click, PictureBox180.Click, PictureBox18B.Click, PictureBox179.Click, PictureBox178.Click, PictureBox177.Click, PictureBox176.Click, PictureBox175.Click, PictureBox174.Click, PictureBox173.Click, PictureBox172.Click, PictureBox171.Click, PictureBox170.Click, PictureBox17B.Click, PictureBox169.Click, PictureBox168.Click, PictureBox167.Click, PictureBox166.Click, PictureBox165.Click, PictureBox164.Click, PictureBox163.Click, PictureBox162.Click, PictureBox161.Click, PictureBox160.Click, PictureBox16B.Click, PictureBox159.Click, PictureBox158.Click, PictureBox157.Click, PictureBox156.Click, PictureBox155.Click, PictureBox154.Click, PictureBox153.Click, PictureBox152.Click, PictureBox151.Click, PictureBox150.Click, PictureBox15B.Click, PictureBox149.Click, PictureBox148.Click, PictureBox147.Click, PictureBox146.Click, PictureBox145.Click, PictureBox144.Click, PictureBox143.Click, PictureBox142.Click, PictureBox141.Click, PictureBox140.Click, PictureBox14B.Click, PictureBox139.Click, PictureBox138.Click, PictureBox137.Click, PictureBox136.Click, PictureBox135.Click, PictureBox134.Click, PictureBox133.Click, PictureBox132.Click, PictureBox131.Click, PictureBox130.Click, PictureBox13B.Click, PictureBox129.Click, PictureBox128.Click, PictureBox127.Click, PictureBox126.Click, PictureBox125.Click, PictureBox124.Click, PictureBox123.Click, PictureBox122.Click, PictureBox121.Click, PictureBox120.Click, PictureBox12B.Click, PictureBox119.Click, PictureBox118.Click, PictureBox117.Click, PictureBox116.Click, PictureBox115.Click, PictureBox114.Click, PictureBox113.Click, PictureBox112.Click, PictureBox111.Click, PictureBox110.Click, PictureBox11B.Click, PictureBox109.Click, PictureBox108.Click, PictureBox107.Click, PictureBox106.Click, PictureBox105.Click, PictureBox104.Click, PictureBox103.Click, PictureBox102.Click, PictureBox101.Click, PictureBox100.Click, PictureBox10B.Click, PictureBox01B.Click, MyBase.Click
        'thisPIC now is a reference to the box, you can use .Name, etc. to get it's properties.
        Dim thisPic As PictureBox = DirectCast(sender, PictureBox)
        'As a defult all free seat is green after click and confirm it reserves
        If thisPic.BackColor = Color.Green Then
            Dim verification2 = MsgBox("This seat " & thisPic.Name & ", is free. Would you like to reserve the seat?", MsgBoxStyle.YesNoCancel)
            If verification2 = MsgBoxResult.Yes Then
                thisPic.BackColor = Color.DarkRed
                MessageBox.Show("Your seat number is : " + thisPic.Name)
                ListBox1.Items.Remove(thisPic.Name)
                ListBox2.Items.Add(thisPic.Name)
            Else
                thisPic.BackColor = Color.Green
            End If
            'for cancelling the reserve after confirm it will cancel and seat get free
        ElseIf thisPic.BackColor = Color.darkRed Then
            Dim verification = MsgBox("This seat, " & thisPic.Tag & ", is already reserved. Would you like to cancel the reservation?", MsgBoxStyle.YesNoCancel)
            If verification = MsgBoxResult.Yes Then
                thisPic.BackColor = Color.Green
                ListBox2.Items.Remove(thisPic.Name)
                ListBox1.Items.Add(thisPic.Name)
            Else
                thisPic.BackColor = Color.DarkRed
            End If
        End If


    End Sub
End Class
