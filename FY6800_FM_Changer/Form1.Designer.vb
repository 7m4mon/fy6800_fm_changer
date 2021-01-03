<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.ModFreqNud = New System.Windows.Forms.NumericUpDown()
        Me.DevFreqNud = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SerialPortSelSpn = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Ch1AmplNud = New System.Windows.Forms.NumericUpDown()
        Me.Ch1FreqNud = New System.Windows.Forms.NumericUpDown()
        CType(Me.ModFreqNud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DevFreqNud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ch1AmplNud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ch1FreqNud, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        Me.SerialPort1.BaudRate = 115200
        Me.SerialPort1.PortName = "COM7"
        '
        'ModFreqNud
        '
        Me.ModFreqNud.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ModFreqNud.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ModFreqNud.Location = New System.Drawing.Point(120, 91)
        Me.ModFreqNud.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.ModFreqNud.Name = "ModFreqNud"
        Me.ModFreqNud.Size = New System.Drawing.Size(78, 31)
        Me.ModFreqNud.TabIndex = 0
        Me.ModFreqNud.ThousandsSeparator = True
        Me.ModFreqNud.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'DevFreqNud
        '
        Me.DevFreqNud.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DevFreqNud.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.DevFreqNud.Location = New System.Drawing.Point(120, 132)
        Me.DevFreqNud.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.DevFreqNud.Name = "DevFreqNud"
        Me.DevFreqNud.Size = New System.Drawing.Size(78, 31)
        Me.DevFreqNud.TabIndex = 1
        Me.DevFreqNud.ThousandsSeparator = True
        Me.DevFreqNud.Value = New Decimal(New Integer() {1500, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Mod Freq"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Deviation"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(204, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Hz"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(204, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 24)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Hz"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button1.Location = New System.Drawing.Point(246, 93)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 70)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Set"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'SerialPortSelSpn
        '
        Me.SerialPortSelSpn.FormattingEnabled = True
        Me.SerialPortSelSpn.Location = New System.Drawing.Point(246, 58)
        Me.SerialPortSelSpn.Name = "SerialPortSelSpn"
        Me.SerialPortSelSpn.Size = New System.Drawing.Size(80, 20)
        Me.SerialPortSelSpn.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(204, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 24)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "V"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(261, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 24)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Hz"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 24)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Amplitude"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label8.Location = New System.Drawing.Point(10, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 24)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "CH1 Freq"
        '
        'Ch1AmplNud
        '
        Me.Ch1AmplNud.DecimalPlaces = 2
        Me.Ch1AmplNud.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Ch1AmplNud.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.Ch1AmplNud.Location = New System.Drawing.Point(120, 48)
        Me.Ch1AmplNud.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.Ch1AmplNud.Name = "Ch1AmplNud"
        Me.Ch1AmplNud.Size = New System.Drawing.Size(78, 31)
        Me.Ch1AmplNud.TabIndex = 11
        Me.Ch1AmplNud.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Ch1FreqNud
        '
        Me.Ch1FreqNud.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Ch1FreqNud.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.Ch1FreqNud.Location = New System.Drawing.Point(120, 7)
        Me.Ch1FreqNud.Maximum = New Decimal(New Integer() {60000000, 0, 0, 0})
        Me.Ch1FreqNud.Name = "Ch1FreqNud"
        Me.Ch1FreqNud.Size = New System.Drawing.Size(128, 31)
        Me.Ch1FreqNud.TabIndex = 10
        Me.Ch1FreqNud.ThousandsSeparator = True
        Me.Ch1FreqNud.Value = New Decimal(New Integer() {450000, 0, 0, 0})
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 180)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Ch1AmplNud)
        Me.Controls.Add(Me.Ch1FreqNud)
        Me.Controls.Add(Me.SerialPortSelSpn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DevFreqNud)
        Me.Controls.Add(Me.ModFreqNud)
        Me.Name = "Form1"
        Me.Text = "FY6800 FM Set"
        CType(Me.ModFreqNud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DevFreqNud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ch1AmplNud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ch1FreqNud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents ModFreqNud As NumericUpDown
    Friend WithEvents DevFreqNud As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents SerialPortSelSpn As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Ch1AmplNud As NumericUpDown
    Friend WithEvents Ch1FreqNud As NumericUpDown
End Class
