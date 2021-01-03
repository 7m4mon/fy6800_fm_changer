Imports System.Threading.Thread
Public Class Form1
    Dim lastCh1Freq As Integer
    Dim lastCh1Ampl As Decimal
    Dim lastModFreq As Integer
    Dim lastDevFreq As Integer
    Dim loadingForm As Boolean = True

    Sub SetFy6800Fm(Optional outp_set As Boolean = False)
        If SerialPortSelSpn.SelectedIndex < 0 Or loadingForm Then
            Exit Sub
        End If
        Try
            SerialPort1.PortName = SerialPortSelSpn.SelectedItem
            SerialPort1.Open()
            SerialPort1.NewLine = vbLf
            If outp_set Then
                SerialPort1.WriteLine("WMN1")   'CH1 ON
                Sleep(500)
                SerialPort1.WriteLine("WFN1")   'CH2 ON
                Sleep(500)
                SerialPort1.WriteLine("WPF5")   'Modulation FM Mode
                Sleep(500)
                SerialPort1.WriteLine("WPN0")   'Sour CH2
                Sleep(500)
            End If
            If lastCh1Freq <> Ch1FreqNud.Value Or outp_set Then
                SerialPort1.WriteLine("WMF" & (Ch1FreqNud.Value * 1000000).ToString)        'frequency fixed to micro Hz
                Sleep(200)
                lastCh1Freq = Ch1FreqNud.Value
            End If
            If lastCh1Ampl <> Ch1AmplNud.Value Or outp_set Then
                SerialPort1.WriteLine("WMA" & (Ch1AmplNud.Value).ToString)                  'XX.XX Volts
                Sleep(200)
                lastCh1Ampl = Ch1AmplNud.Value
            End If

            If lastModFreq <> ModFreqNud.Value Or outp_set Then
                SerialPort1.WriteLine("WFF" & (ModFreqNud.Value * 1000000).ToString)        'frequency fixed to micro Hz
                Sleep(200)
                lastModFreq = ModFreqNud.Value
            End If

            If lastDevFreq <> DevFreqNud.Value Then
                SerialPort1.WriteLine("WFM" & (DevFreqNud.Value * 1000000 * 2).ToString)    'p-p to (p-p)/2
                Sleep(200)
                lastDevFreq = DevFreqNud.Value
            Else
                SerialPort1.WriteLine("WPF5")   'Modulation FM Mode
                Sleep(200)
            End If

            SerialPort1.Close()
            Sleep(100)
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub

    Private Sub GetSerialPortNames()
        ' Show all available COM ports.
        For Each sp As String In My.Computer.Ports.SerialPortNames
            SerialPortSelSpn.Items.Add(sp)
        Next
        If SerialPortSelSpn.Items.Count > 0 Then   'シリアルポートが一つでも見つかったら
            SerialPortSelSpn.SelectedIndex = SerialPortSelSpn.Items.Count - 1
        Else
            MsgBox("!!! No SerialPorts !!!")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadingForm = True
        GetSerialPortNames()
        With My.Settings
            lastCh1Freq = .lastCh1Freq
            lastCh1Ampl = .lastCh1Ampl
            lastModFreq = .lastModFreq
            lastDevFreq = .lastDevFreq
            Ch1FreqNud.Value = .lastCh1Freq
            Ch1AmplNud.Value = .lastCh1Ampl
            ModFreqNud.Value = .lastModFreq
            DevFreqNud.Value = .lastDevFreq
        End With
        loadingForm = False
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        With My.Settings
            .lastCh1Freq = lastCh1Freq
            .lastCh1Ampl = lastCh1Ampl
            .lastModFreq = lastModFreq
            .lastDevFreq = lastDevFreq
        End With
    End Sub

    Private Sub Ch1FreqNud_ValueChanged(sender As Object, e As EventArgs) Handles Ch1FreqNud.ValueChanged
        SetFy6800Fm()
    End Sub
    Private Sub Ch1AmplNud_ValueChanged(sender As Object, e As EventArgs) Handles Ch1AmplNud.ValueChanged
        SetFy6800Fm()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SetFy6800Fm(True)
    End Sub

    Private Sub DevFreqNud_ValueChanged(sender As Object, e As EventArgs) Handles DevFreqNud.ValueChanged
        SetFy6800Fm()
    End Sub
    Private Sub ModFreqNud_ValueChanged(sender As Object, e As EventArgs) Handles ModFreqNud.ValueChanged
        SetFy6800Fm()
    End Sub
End Class
