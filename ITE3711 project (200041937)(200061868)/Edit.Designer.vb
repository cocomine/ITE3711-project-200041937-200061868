﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Edit_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Edit_Form))
        Me.Input_gp = New System.Windows.Forms.GroupBox()
        Me.Result_gb = New System.Windows.Forms.GroupBox()
        Me.Remarks_lb = New System.Windows.Forms.Label()
        Me.Module_Grade_lb = New System.Windows.Forms.Label()
        Me.Module_Marks_lb = New System.Windows.Forms.Label()
        Me.CA_Marks_lb = New System.Windows.Forms.Label()
        Me.CA_Mark__tb = New System.Windows.Forms.TextBox()
        Me.Remarks_tb = New System.Windows.Forms.TextBox()
        Me.Module_Grade_tb = New System.Windows.Forms.TextBox()
        Me.Module_Marks_tb = New System.Windows.Forms.TextBox()
        Me.lnput_CA_gb = New System.Windows.Forms.GroupBox()
        Me.Exam_tb = New System.Windows.Forms.TextBox()
        Me.Project_tb = New System.Windows.Forms.TextBox()
        Me.Quizzes_tb = New System.Windows.Forms.TextBox()
        Me.Test_tb = New System.Windows.Forms.TextBox()
        Me.Exam_lb = New System.Windows.Forms.Label()
        Me.Quizzes_lb = New System.Windows.Forms.Label()
        Me.Project_lb = New System.Windows.Forms.Label()
        Me.Test_lb = New System.Windows.Forms.Label()
        Me.CA_lb = New System.Windows.Forms.Label()
        Me.Confirm_bt = New System.Windows.Forms.Button()
        Me.Name_lb = New System.Windows.Forms.Label()
        Me.Name_tb = New System.Windows.Forms.TextBox()
        Me.Save_bt = New System.Windows.Forms.Button()
        Me.Input_gp.SuspendLayout()
        Me.Result_gb.SuspendLayout()
        Me.lnput_CA_gb.SuspendLayout()
        Me.SuspendLayout()
        '
        'Input_gp
        '
        Me.Input_gp.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Input_gp.Controls.Add(Me.Result_gb)
        Me.Input_gp.Controls.Add(Me.lnput_CA_gb)
        Me.Input_gp.Controls.Add(Me.Name_lb)
        Me.Input_gp.Controls.Add(Me.Name_tb)
        Me.Input_gp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Input_gp.ForeColor = System.Drawing.Color.Black
        Me.Input_gp.Location = New System.Drawing.Point(0, 0)
        Me.Input_gp.Name = "Input_gp"
        Me.Input_gp.Size = New System.Drawing.Size(638, 466)
        Me.Input_gp.TabIndex = 1
        Me.Input_gp.TabStop = False
        Me.Input_gp.Text = " Marks and Grade for Individual Student "
        '
        'Result_gb
        '
        Me.Result_gb.Controls.Add(Me.Remarks_lb)
        Me.Result_gb.Controls.Add(Me.Module_Grade_lb)
        Me.Result_gb.Controls.Add(Me.Module_Marks_lb)
        Me.Result_gb.Controls.Add(Me.CA_Marks_lb)
        Me.Result_gb.Controls.Add(Me.CA_Mark__tb)
        Me.Result_gb.Controls.Add(Me.Remarks_tb)
        Me.Result_gb.Controls.Add(Me.Module_Grade_tb)
        Me.Result_gb.Controls.Add(Me.Module_Marks_tb)
        Me.Result_gb.Location = New System.Drawing.Point(10, 284)
        Me.Result_gb.Name = "Result_gb"
        Me.Result_gb.Size = New System.Drawing.Size(605, 165)
        Me.Result_gb.TabIndex = 11
        Me.Result_gb.TabStop = False
        Me.Result_gb.Text = "Module Result"
        '
        'Remarks_lb
        '
        Me.Remarks_lb.AutoSize = True
        Me.Remarks_lb.Location = New System.Drawing.Point(316, 117)
        Me.Remarks_lb.Name = "Remarks_lb"
        Me.Remarks_lb.Size = New System.Drawing.Size(80, 20)
        Me.Remarks_lb.TabIndex = 12
        Me.Remarks_lb.Text = "Remarks"
        '
        'Module_Grade_lb
        '
        Me.Module_Grade_lb.AutoSize = True
        Me.Module_Grade_lb.Location = New System.Drawing.Point(32, 120)
        Me.Module_Grade_lb.Name = "Module_Grade_lb"
        Me.Module_Grade_lb.Size = New System.Drawing.Size(122, 20)
        Me.Module_Grade_lb.TabIndex = 11
        Me.Module_Grade_lb.Text = "Module Grade"
        '
        'Module_Marks_lb
        '
        Me.Module_Marks_lb.AutoSize = True
        Me.Module_Marks_lb.Location = New System.Drawing.Point(276, 61)
        Me.Module_Marks_lb.Name = "Module_Marks_lb"
        Me.Module_Marks_lb.Size = New System.Drawing.Size(120, 20)
        Me.Module_Marks_lb.TabIndex = 10
        Me.Module_Marks_lb.Text = "Module Marks"
        '
        'CA_Marks_lb
        '
        Me.CA_Marks_lb.AutoSize = True
        Me.CA_Marks_lb.Location = New System.Drawing.Point(63, 58)
        Me.CA_Marks_lb.Name = "CA_Marks_lb"
        Me.CA_Marks_lb.Size = New System.Drawing.Size(91, 20)
        Me.CA_Marks_lb.TabIndex = 9
        Me.CA_Marks_lb.Text = "CA Marks "
        '
        'CA_Mark__tb
        '
        Me.CA_Mark__tb.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CA_Mark__tb.Cursor = System.Windows.Forms.Cursors.No
        Me.CA_Mark__tb.Location = New System.Drawing.Point(160, 58)
        Me.CA_Mark__tb.Name = "CA_Mark__tb"
        Me.CA_Mark__tb.ReadOnly = True
        Me.CA_Mark__tb.Size = New System.Drawing.Size(110, 26)
        Me.CA_Mark__tb.TabIndex = 101
        Me.CA_Mark__tb.TabStop = False
        Me.CA_Mark__tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Remarks_tb
        '
        Me.Remarks_tb.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Remarks_tb.Cursor = System.Windows.Forms.Cursors.No
        Me.Remarks_tb.Location = New System.Drawing.Point(417, 113)
        Me.Remarks_tb.Name = "Remarks_tb"
        Me.Remarks_tb.ReadOnly = True
        Me.Remarks_tb.Size = New System.Drawing.Size(128, 26)
        Me.Remarks_tb.TabIndex = 104
        Me.Remarks_tb.TabStop = False
        Me.Remarks_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Module_Grade_tb
        '
        Me.Module_Grade_tb.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Module_Grade_tb.Cursor = System.Windows.Forms.Cursors.No
        Me.Module_Grade_tb.Location = New System.Drawing.Point(160, 117)
        Me.Module_Grade_tb.Name = "Module_Grade_tb"
        Me.Module_Grade_tb.ReadOnly = True
        Me.Module_Grade_tb.Size = New System.Drawing.Size(110, 26)
        Me.Module_Grade_tb.TabIndex = 103
        Me.Module_Grade_tb.TabStop = False
        Me.Module_Grade_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Module_Marks_tb
        '
        Me.Module_Marks_tb.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Module_Marks_tb.Cursor = System.Windows.Forms.Cursors.No
        Me.Module_Marks_tb.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Module_Marks_tb.Location = New System.Drawing.Point(417, 58)
        Me.Module_Marks_tb.Name = "Module_Marks_tb"
        Me.Module_Marks_tb.ReadOnly = True
        Me.Module_Marks_tb.Size = New System.Drawing.Size(128, 26)
        Me.Module_Marks_tb.TabIndex = 102
        Me.Module_Marks_tb.TabStop = False
        Me.Module_Marks_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lnput_CA_gb
        '
        Me.lnput_CA_gb.Controls.Add(Me.Exam_tb)
        Me.lnput_CA_gb.Controls.Add(Me.Project_tb)
        Me.lnput_CA_gb.Controls.Add(Me.Quizzes_tb)
        Me.lnput_CA_gb.Controls.Add(Me.Test_tb)
        Me.lnput_CA_gb.Controls.Add(Me.Exam_lb)
        Me.lnput_CA_gb.Controls.Add(Me.Quizzes_lb)
        Me.lnput_CA_gb.Controls.Add(Me.Project_lb)
        Me.lnput_CA_gb.Controls.Add(Me.Test_lb)
        Me.lnput_CA_gb.Controls.Add(Me.CA_lb)
        Me.lnput_CA_gb.Controls.Add(Me.Confirm_bt)
        Me.lnput_CA_gb.Location = New System.Drawing.Point(10, 99)
        Me.lnput_CA_gb.Name = "lnput_CA_gb"
        Me.lnput_CA_gb.Size = New System.Drawing.Size(605, 180)
        Me.lnput_CA_gb.TabIndex = 10
        Me.lnput_CA_gb.TabStop = False
        Me.lnput_CA_gb.Text = "Input CA and Exam Marks "
        '
        'Exam_tb
        '
        Me.Exam_tb.Location = New System.Drawing.Point(328, 125)
        Me.Exam_tb.MaxLength = 5
        Me.Exam_tb.Name = "Exam_tb"
        Me.Exam_tb.Size = New System.Drawing.Size(100, 26)
        Me.Exam_tb.TabIndex = 5
        Me.Exam_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Project_tb
        '
        Me.Project_tb.Location = New System.Drawing.Point(96, 125)
        Me.Project_tb.MaxLength = 5
        Me.Project_tb.Name = "Project_tb"
        Me.Project_tb.Size = New System.Drawing.Size(100, 26)
        Me.Project_tb.TabIndex = 4
        Me.Project_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Quizzes_tb
        '
        Me.Quizzes_tb.Location = New System.Drawing.Point(328, 70)
        Me.Quizzes_tb.MaxLength = 5
        Me.Quizzes_tb.Name = "Quizzes_tb"
        Me.Quizzes_tb.Size = New System.Drawing.Size(100, 26)
        Me.Quizzes_tb.TabIndex = 3
        Me.Quizzes_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Test_tb
        '
        Me.Test_tb.Location = New System.Drawing.Point(96, 70)
        Me.Test_tb.MaxLength = 5
        Me.Test_tb.Name = "Test_tb"
        Me.Test_tb.Size = New System.Drawing.Size(100, 26)
        Me.Test_tb.TabIndex = 2
        Me.Test_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Exam_lb
        '
        Me.Exam_lb.AutoSize = True
        Me.Exam_lb.Location = New System.Drawing.Point(254, 130)
        Me.Exam_lb.Name = "Exam_lb"
        Me.Exam_lb.Size = New System.Drawing.Size(58, 20)
        Me.Exam_lb.TabIndex = 14
        Me.Exam_lb.Text = "Exam:"
        '
        'Quizzes_lb
        '
        Me.Quizzes_lb.AutoSize = True
        Me.Quizzes_lb.Location = New System.Drawing.Point(234, 73)
        Me.Quizzes_lb.Name = "Quizzes_lb"
        Me.Quizzes_lb.Size = New System.Drawing.Size(78, 20)
        Me.Quizzes_lb.TabIndex = 13
        Me.Quizzes_lb.Text = "Quizzes:"
        '
        'Project_lb
        '
        Me.Project_lb.AutoSize = True
        Me.Project_lb.Location = New System.Drawing.Point(7, 125)
        Me.Project_lb.Name = "Project_lb"
        Me.Project_lb.Size = New System.Drawing.Size(70, 20)
        Me.Project_lb.TabIndex = 12
        Me.Project_lb.Text = "Project:"
        '
        'Test_lb
        '
        Me.Test_lb.AutoSize = True
        Me.Test_lb.Location = New System.Drawing.Point(28, 73)
        Me.Test_lb.Name = "Test_lb"
        Me.Test_lb.Size = New System.Drawing.Size(49, 20)
        Me.Test_lb.TabIndex = 11
        Me.Test_lb.Text = "Test:"
        '
        'CA_lb
        '
        Me.CA_lb.AutoSize = True
        Me.CA_lb.Location = New System.Drawing.Point(10, 32)
        Me.CA_lb.Name = "CA_lb"
        Me.CA_lb.Size = New System.Drawing.Size(144, 20)
        Me.CA_lb.TabIndex = 10
        Me.CA_lb.Text = "CA Components:"
        '
        'Confirm_bt
        '
        Me.Confirm_bt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Confirm_bt.Location = New System.Drawing.Point(463, 93)
        Me.Confirm_bt.Name = "Confirm_bt"
        Me.Confirm_bt.Size = New System.Drawing.Size(114, 40)
        Me.Confirm_bt.TabIndex = 6
        Me.Confirm_bt.Text = "Confirm"
        Me.Confirm_bt.UseVisualStyleBackColor = True
        '
        'Name_lb
        '
        Me.Name_lb.AutoSize = True
        Me.Name_lb.Location = New System.Drawing.Point(20, 45)
        Me.Name_lb.Name = "Name_lb"
        Me.Name_lb.Size = New System.Drawing.Size(60, 20)
        Me.Name_lb.TabIndex = 7
        Me.Name_lb.Text = "Name:"
        '
        'Name_tb
        '
        Me.Name_tb.BackColor = System.Drawing.Color.White
        Me.Name_tb.Location = New System.Drawing.Point(86, 41)
        Me.Name_tb.MaxLength = 100
        Me.Name_tb.Name = "Name_tb"
        Me.Name_tb.Size = New System.Drawing.Size(501, 26)
        Me.Name_tb.TabIndex = 1
        Me.Name_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Save_bt
        '
        Me.Save_bt.Enabled = False
        Me.Save_bt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save_bt.Location = New System.Drawing.Point(511, 472)
        Me.Save_bt.Name = "Save_bt"
        Me.Save_bt.Size = New System.Drawing.Size(104, 29)
        Me.Save_bt.TabIndex = 7
        Me.Save_bt.Text = "Save"
        Me.Save_bt.UseVisualStyleBackColor = True
        '
        'Edit_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(638, 511)
        Me.Controls.Add(Me.Save_bt)
        Me.Controls.Add(Me.Input_gp)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Edit_Form"
        Me.Text = "Edit record"
        Me.Input_gp.ResumeLayout(False)
        Me.Input_gp.PerformLayout()
        Me.Result_gb.ResumeLayout(False)
        Me.Result_gb.PerformLayout()
        Me.lnput_CA_gb.ResumeLayout(False)
        Me.lnput_CA_gb.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Input_gp As GroupBox
    Friend WithEvents Result_gb As GroupBox
    Friend WithEvents Remarks_lb As Label
    Friend WithEvents Module_Grade_lb As Label
    Friend WithEvents Module_Marks_lb As Label
    Friend WithEvents CA_Marks_lb As Label
    Friend WithEvents CA_Mark__tb As TextBox
    Friend WithEvents Remarks_tb As TextBox
    Friend WithEvents Module_Grade_tb As TextBox
    Friend WithEvents Module_Marks_tb As TextBox
    Friend WithEvents lnput_CA_gb As GroupBox
    Friend WithEvents Exam_tb As TextBox
    Friend WithEvents Project_tb As TextBox
    Friend WithEvents Quizzes_tb As TextBox
    Friend WithEvents Test_tb As TextBox
    Friend WithEvents Exam_lb As Label
    Friend WithEvents Quizzes_lb As Label
    Friend WithEvents Project_lb As Label
    Friend WithEvents Test_lb As Label
    Friend WithEvents CA_lb As Label
    Friend WithEvents Confirm_bt As Button
    Friend WithEvents Name_lb As Label
    Friend WithEvents Name_tb As TextBox
    Friend WithEvents Save_bt As Button
End Class
