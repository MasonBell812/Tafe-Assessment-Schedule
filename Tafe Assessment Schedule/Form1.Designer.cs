namespace Tafe_Assessment_Schedule
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.main_Panel = new System.Windows.Forms.Panel();
            this.delete_Button = new System.Windows.Forms.Button();
            this.save_Button = new System.Windows.Forms.Button();
            this.refresh_Button = new System.Windows.Forms.Button();
            this.edit_Button = new System.Windows.Forms.Button();
            this.addAssessment_Button = new System.Windows.Forms.Button();
            this.table_DataGridView = new System.Windows.Forms.DataGridView();
            this.details_Panel = new System.Windows.Forms.Panel();
            this.saveUpdate_Button = new System.Windows.Forms.Button();
            this.add_Button = new System.Windows.Forms.Button();
            this.completed_CheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.resubmit_CheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.date_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.at_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.unit_ComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.title_Label = new System.Windows.Forms.Label();
            this.back_Button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.description_TextBox = new System.Windows.Forms.TextBox();
            this.main_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_DataGridView)).BeginInit();
            this.details_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_Panel
            // 
            this.main_Panel.Controls.Add(this.delete_Button);
            this.main_Panel.Controls.Add(this.save_Button);
            this.main_Panel.Controls.Add(this.refresh_Button);
            this.main_Panel.Controls.Add(this.edit_Button);
            this.main_Panel.Controls.Add(this.addAssessment_Button);
            this.main_Panel.Controls.Add(this.table_DataGridView);
            this.main_Panel.Location = new System.Drawing.Point(1, 1);
            this.main_Panel.Name = "main_Panel";
            this.main_Panel.Size = new System.Drawing.Size(799, 450);
            this.main_Panel.TabIndex = 0;
            // 
            // delete_Button
            // 
            this.delete_Button.Location = new System.Drawing.Point(335, 399);
            this.delete_Button.Name = "delete_Button";
            this.delete_Button.Size = new System.Drawing.Size(124, 38);
            this.delete_Button.TabIndex = 5;
            this.delete_Button.Text = "DELETE";
            this.delete_Button.UseVisualStyleBackColor = true;
            this.delete_Button.Click += new System.EventHandler(this.delete_Button_Click);
            // 
            // save_Button
            // 
            this.save_Button.Location = new System.Drawing.Point(659, 399);
            this.save_Button.Name = "save_Button";
            this.save_Button.Size = new System.Drawing.Size(124, 38);
            this.save_Button.TabIndex = 4;
            this.save_Button.Text = "Save";
            this.save_Button.UseVisualStyleBackColor = true;
            this.save_Button.Click += new System.EventHandler(this.save_Button_Click);
            // 
            // refresh_Button
            // 
            this.refresh_Button.Location = new System.Drawing.Point(497, 399);
            this.refresh_Button.Name = "refresh_Button";
            this.refresh_Button.Size = new System.Drawing.Size(124, 38);
            this.refresh_Button.TabIndex = 3;
            this.refresh_Button.Text = "Refresh Table";
            this.refresh_Button.UseVisualStyleBackColor = true;
            this.refresh_Button.Click += new System.EventHandler(this.refresh_Button_Click);
            // 
            // edit_Button
            // 
            this.edit_Button.Location = new System.Drawing.Point(173, 399);
            this.edit_Button.Name = "edit_Button";
            this.edit_Button.Size = new System.Drawing.Size(124, 38);
            this.edit_Button.TabIndex = 2;
            this.edit_Button.Text = "Edit Assessment";
            this.edit_Button.UseVisualStyleBackColor = true;
            this.edit_Button.Click += new System.EventHandler(this.edit_Button_Click);
            // 
            // addAssessment_Button
            // 
            this.addAssessment_Button.Location = new System.Drawing.Point(11, 399);
            this.addAssessment_Button.Name = "addAssessment_Button";
            this.addAssessment_Button.Size = new System.Drawing.Size(124, 38);
            this.addAssessment_Button.TabIndex = 1;
            this.addAssessment_Button.Text = "Add Assessment";
            this.addAssessment_Button.UseVisualStyleBackColor = true;
            this.addAssessment_Button.Click += new System.EventHandler(this.addAssessment_Button_Click);
            // 
            // table_DataGridView
            // 
            this.table_DataGridView.AllowUserToAddRows = false;
            this.table_DataGridView.AllowUserToDeleteRows = false;
            this.table_DataGridView.AllowUserToResizeColumns = false;
            this.table_DataGridView.AllowUserToResizeRows = false;
            this.table_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_DataGridView.Location = new System.Drawing.Point(3, 3);
            this.table_DataGridView.Name = "table_DataGridView";
            this.table_DataGridView.ReadOnly = true;
            this.table_DataGridView.RowTemplate.Height = 25;
            this.table_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table_DataGridView.Size = new System.Drawing.Size(793, 390);
            this.table_DataGridView.TabIndex = 0;
            // 
            // details_Panel
            // 
            this.details_Panel.Controls.Add(this.description_TextBox);
            this.details_Panel.Controls.Add(this.label6);
            this.details_Panel.Controls.Add(this.saveUpdate_Button);
            this.details_Panel.Controls.Add(this.add_Button);
            this.details_Panel.Controls.Add(this.completed_CheckBox);
            this.details_Panel.Controls.Add(this.label5);
            this.details_Panel.Controls.Add(this.resubmit_CheckBox);
            this.details_Panel.Controls.Add(this.label4);
            this.details_Panel.Controls.Add(this.date_DateTimePicker);
            this.details_Panel.Controls.Add(this.label3);
            this.details_Panel.Controls.Add(this.at_TextBox);
            this.details_Panel.Controls.Add(this.label2);
            this.details_Panel.Controls.Add(this.unit_ComboBox);
            this.details_Panel.Controls.Add(this.label1);
            this.details_Panel.Controls.Add(this.title_Label);
            this.details_Panel.Controls.Add(this.back_Button);
            this.details_Panel.Location = new System.Drawing.Point(0, 0);
            this.details_Panel.Name = "details_Panel";
            this.details_Panel.Size = new System.Drawing.Size(799, 450);
            this.details_Panel.TabIndex = 5;
            // 
            // saveUpdate_Button
            // 
            this.saveUpdate_Button.Location = new System.Drawing.Point(142, 400);
            this.saveUpdate_Button.Name = "saveUpdate_Button";
            this.saveUpdate_Button.Size = new System.Drawing.Size(124, 38);
            this.saveUpdate_Button.TabIndex = 13;
            this.saveUpdate_Button.Text = "Save Update";
            this.saveUpdate_Button.UseVisualStyleBackColor = true;
            this.saveUpdate_Button.Click += new System.EventHandler(this.saveUpdate_Button_Click);
            // 
            // add_Button
            // 
            this.add_Button.Location = new System.Drawing.Point(142, 400);
            this.add_Button.Name = "add_Button";
            this.add_Button.Size = new System.Drawing.Size(124, 38);
            this.add_Button.TabIndex = 12;
            this.add_Button.Text = "Add";
            this.add_Button.UseVisualStyleBackColor = true;
            this.add_Button.Click += new System.EventHandler(this.add_Button_Click);
            // 
            // completed_CheckBox
            // 
            this.completed_CheckBox.AutoSize = true;
            this.completed_CheckBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.completed_CheckBox.Location = new System.Drawing.Point(126, 256);
            this.completed_CheckBox.Name = "completed_CheckBox";
            this.completed_CheckBox.Size = new System.Drawing.Size(15, 14);
            this.completed_CheckBox.TabIndex = 11;
            this.completed_CheckBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Completed:";
            // 
            // resubmit_CheckBox
            // 
            this.resubmit_CheckBox.AutoSize = true;
            this.resubmit_CheckBox.Location = new System.Drawing.Point(126, 215);
            this.resubmit_CheckBox.Name = "resubmit_CheckBox";
            this.resubmit_CheckBox.Size = new System.Drawing.Size(15, 14);
            this.resubmit_CheckBox.TabIndex = 9;
            this.resubmit_CheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Resubmit:";
            // 
            // date_DateTimePicker
            // 
            this.date_DateTimePicker.CustomFormat = "d/M/yyyy hh:mm:ss tt";
            this.date_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_DateTimePicker.Location = new System.Drawing.Point(126, 160);
            this.date_DateTimePicker.Name = "date_DateTimePicker";
            this.date_DateTimePicker.Size = new System.Drawing.Size(211, 23);
            this.date_DateTimePicker.TabIndex = 7;
            this.date_DateTimePicker.MouseDown += new System.Windows.Forms.MouseEventHandler(this.date_DateTimePicker_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date:";
            // 
            // at_TextBox
            // 
            this.at_TextBox.Location = new System.Drawing.Point(126, 115);
            this.at_TextBox.Name = "at_TextBox";
            this.at_TextBox.Size = new System.Drawing.Size(67, 23);
            this.at_TextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "AT:";
            // 
            // unit_ComboBox
            // 
            this.unit_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unit_ComboBox.FormattingEnabled = true;
            this.unit_ComboBox.Location = new System.Drawing.Point(122, 67);
            this.unit_ComboBox.Name = "unit_ComboBox";
            this.unit_ComboBox.Size = new System.Drawing.Size(385, 23);
            this.unit_ComboBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Unit:";
            // 
            // title_Label
            // 
            this.title_Label.AutoSize = true;
            this.title_Label.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title_Label.Location = new System.Drawing.Point(12, 9);
            this.title_Label.Name = "title_Label";
            this.title_Label.Size = new System.Drawing.Size(272, 37);
            this.title_Label.TabIndex = 1;
            this.title_Label.Text = "Add New Assignment";
            // 
            // back_Button
            // 
            this.back_Button.Location = new System.Drawing.Point(12, 400);
            this.back_Button.Name = "back_Button";
            this.back_Button.Size = new System.Drawing.Size(124, 38);
            this.back_Button.TabIndex = 0;
            this.back_Button.Text = "Back";
            this.back_Button.UseVisualStyleBackColor = true;
            this.back_Button.Click += new System.EventHandler(this.back_Button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Description:";
            // 
            // description_TextBox
            // 
            this.description_TextBox.Location = new System.Drawing.Point(130, 294);
            this.description_TextBox.Multiline = true;
            this.description_TextBox.Name = "description_TextBox";
            this.description_TextBox.Size = new System.Drawing.Size(613, 88);
            this.description_TextBox.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.details_Panel);
            this.Controls.Add(this.main_Panel);
            this.Name = "Form1";
            this.Text = "Tafe Assessment Schedule";
            this.main_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table_DataGridView)).EndInit();
            this.details_Panel.ResumeLayout(false);
            this.details_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel main_Panel;
        private System.Windows.Forms.DataGridView table_DataGridView;
        private System.Windows.Forms.Button save_Button;
        private System.Windows.Forms.Button refresh_Button;
        private System.Windows.Forms.Button edit_Button;
        private System.Windows.Forms.Button addAssessment_Button;
        private System.Windows.Forms.Panel details_Panel;
        private System.Windows.Forms.Button back_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox unit_ComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label title_Label;
        private System.Windows.Forms.TextBox at_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date_DateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox resubmit_CheckBox;
        private System.Windows.Forms.CheckBox completed_CheckBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button add_Button;
        private System.Windows.Forms.Button delete_Button;
        private System.Windows.Forms.Button saveUpdate_Button;
        private System.Windows.Forms.TextBox description_TextBox;
        private System.Windows.Forms.Label label6;
    }
}
