<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReservations
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.picAirBnB = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblNumNights = New System.Windows.Forms.Label()
        Me.lblCostOfStay = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.txtNumNights = New System.Windows.Forms.TextBox()
        Me.btnDisplayCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picAirBnB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picAirBnB
        '
        Me.picAirBnB.Image = Global.Airbnb.My.Resources.Resources.airbnb
        Me.picAirBnB.Location = New System.Drawing.Point(10, 4)
        Me.picAirBnB.Name = "picAirBnB"
        Me.picAirBnB.Size = New System.Drawing.Size(380, 403)
        Me.picAirBnB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAirBnB.TabIndex = 0
        Me.picAirBnB.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Cooper Black", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(400, 40)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(322, 42)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Orlando AirBnB"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(462, 97)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(199, 19)
        Me.lblPrice.TabIndex = 2
        Me.lblPrice.Text = "Only $XX.XX per night"
        '
        'lblNumNights
        '
        Me.lblNumNights.AutoSize = True
        Me.lblNumNights.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumNights.Location = New System.Drawing.Point(412, 149)
        Me.lblNumNights.Name = "lblNumNights"
        Me.lblNumNights.Size = New System.Drawing.Size(149, 19)
        Me.lblNumNights.TabIndex = 3
        Me.lblNumNights.Text = "Number of Nights:"
        '
        'lblCostOfStay
        '
        Me.lblCostOfStay.AutoSize = True
        Me.lblCostOfStay.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostOfStay.Location = New System.Drawing.Point(412, 209)
        Me.lblCostOfStay.Name = "lblCostOfStay"
        Me.lblCostOfStay.Size = New System.Drawing.Size(108, 19)
        Me.lblCostOfStay.TabIndex = 4
        Me.lblCostOfStay.Text = "Cost of Stay:"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(628, 209)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(77, 19)
        Me.lblTotalCost.TabIndex = 5
        Me.lblTotalCost.Text = "$XXX.XX"
        '
        'txtNumNights
        '
        Me.txtNumNights.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumNights.Location = New System.Drawing.Point(632, 142)
        Me.txtNumNights.Name = "txtNumNights"
        Me.txtNumNights.Size = New System.Drawing.Size(29, 26)
        Me.txtNumNights.TabIndex = 1
        '
        'btnDisplayCost
        '
        Me.btnDisplayCost.BackColor = System.Drawing.Color.LightGray
        Me.btnDisplayCost.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDisplayCost.FlatAppearance.BorderSize = 0
        Me.btnDisplayCost.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayCost.Location = New System.Drawing.Point(407, 301)
        Me.btnDisplayCost.Margin = New System.Windows.Forms.Padding(0)
        Me.btnDisplayCost.Name = "btnDisplayCost"
        Me.btnDisplayCost.Size = New System.Drawing.Size(90, 30)
        Me.btnDisplayCost.TabIndex = 2
        Me.btnDisplayCost.Text = "Display Cost"
        Me.btnDisplayCost.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.LightGray
        Me.btnClear.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(519, 301)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(90, 30)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.LightGray
        Me.btnExit.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(631, 301)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 30)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmReservations
        '
        Me.AcceptButton = Me.btnDisplayCost
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(734, 411)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplayCost)
        Me.Controls.Add(Me.txtNumNights)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblCostOfStay)
        Me.Controls.Add(Me.lblNumNights)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picAirBnB)
        Me.Name = "frmReservations"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AirBnB Reservations"
        CType(Me.picAirBnB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picAirBnB As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblNumNights As Label
    Friend WithEvents lblCostOfStay As Label
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents txtNumNights As TextBox
    Friend WithEvents btnDisplayCost As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
