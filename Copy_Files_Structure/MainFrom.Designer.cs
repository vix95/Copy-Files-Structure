namespace Copy_Files_Structure
{
    partial class MainFrom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.load_path = new System.Windows.Forms.Label();
            this.load_path_button = new System.Windows.Forms.Button();
            this.select_file_type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.from_modify_date_pickup = new System.Windows.Forms.DateTimePicker();
            this.to_modify_date_pickup = new System.Windows.Forms.DateTimePicker();
            this.to_creation_date_pickup = new System.Windows.Forms.DateTimePicker();
            this.from_creation_date_pickup = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.filter_text = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.copy_path_button = new System.Windows.Forms.Button();
            this.copy_path = new System.Windows.Forms.Label();
            this.save_structure = new System.Windows.Forms.CheckBox();
            this.start_copying = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // load_path
            // 
            this.load_path.AutoSize = true;
            this.load_path.Location = new System.Drawing.Point(109, 11);
            this.load_path.Name = "load_path";
            this.load_path.Size = new System.Drawing.Size(31, 13);
            this.load_path.TabIndex = 1;
            this.load_path.Text = "C:\\...";
            // 
            // load_path_button
            // 
            this.load_path_button.Location = new System.Drawing.Point(12, 6);
            this.load_path_button.Name = "load_path_button";
            this.load_path_button.Size = new System.Drawing.Size(91, 23);
            this.load_path_button.TabIndex = 2;
            this.load_path_button.Text = "Load Path";
            this.load_path_button.UseVisualStyleBackColor = true;
            this.load_path_button.Click += new System.EventHandler(this.Load_path_button_Click);
            // 
            // select_file_type
            // 
            this.select_file_type.FormattingEnabled = true;
            this.select_file_type.Items.AddRange(new object[] {
            ".*",
            ".txt",
            ".pdf",
            ".xml",
            ".csv"});
            this.select_file_type.Location = new System.Drawing.Point(12, 35);
            this.select_file_type.Name = "select_file_type";
            this.select_file_type.Size = new System.Drawing.Size(151, 21);
            this.select_file_type.TabIndex = 3;
            this.select_file_type.Text = "Select file type...";
            this.select_file_type.SelectedIndexChanged += new System.EventHandler(this.Select_file_type_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "*Select or type file type which you would like to copy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Modify date range";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "-";
            // 
            // from_modify_date_pickup
            // 
            this.from_modify_date_pickup.Location = new System.Drawing.Point(12, 122);
            this.from_modify_date_pickup.Name = "from_modify_date_pickup";
            this.from_modify_date_pickup.Size = new System.Drawing.Size(200, 20);
            this.from_modify_date_pickup.TabIndex = 11;
            this.from_modify_date_pickup.ValueChanged += new System.EventHandler(this.From_modify_date_pickup_ValueChanged);
            // 
            // to_modify_date_pickup
            // 
            this.to_modify_date_pickup.Location = new System.Drawing.Point(234, 121);
            this.to_modify_date_pickup.Name = "to_modify_date_pickup";
            this.to_modify_date_pickup.Size = new System.Drawing.Size(200, 20);
            this.to_modify_date_pickup.TabIndex = 12;
            this.to_modify_date_pickup.ValueChanged += new System.EventHandler(this.To_modify_date_pickup_ValueChanged);
            // 
            // to_creation_date_pickup
            // 
            this.to_creation_date_pickup.Location = new System.Drawing.Point(234, 160);
            this.to_creation_date_pickup.Name = "to_creation_date_pickup";
            this.to_creation_date_pickup.Size = new System.Drawing.Size(200, 20);
            this.to_creation_date_pickup.TabIndex = 16;
            this.to_creation_date_pickup.ValueChanged += new System.EventHandler(this.To_creation_date_pickup_ValueChanged);
            // 
            // from_creation_date_pickup
            // 
            this.from_creation_date_pickup.Location = new System.Drawing.Point(12, 161);
            this.from_creation_date_pickup.Name = "from_creation_date_pickup";
            this.from_creation_date_pickup.Size = new System.Drawing.Size(200, 20);
            this.from_creation_date_pickup.TabIndex = 15;
            this.from_creation_date_pickup.ValueChanged += new System.EventHandler(this.From_creation_date_pickup_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Creation date range";
            // 
            // filter_text
            // 
            this.filter_text.Location = new System.Drawing.Point(12, 62);
            this.filter_text.Name = "filter_text";
            this.filter_text.Size = new System.Drawing.Size(151, 20);
            this.filter_text.TabIndex = 17;
            this.filter_text.Text = "Type text...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "*Type text which you would like to filter";
            // 
            // copy_path_button
            // 
            this.copy_path_button.Location = new System.Drawing.Point(12, 208);
            this.copy_path_button.Name = "copy_path_button";
            this.copy_path_button.Size = new System.Drawing.Size(91, 23);
            this.copy_path_button.TabIndex = 20;
            this.copy_path_button.Text = "Target Path";
            this.copy_path_button.UseVisualStyleBackColor = true;
            this.copy_path_button.Click += new System.EventHandler(this.Copy_path_button_Click);
            // 
            // copy_path
            // 
            this.copy_path.AutoSize = true;
            this.copy_path.Location = new System.Drawing.Point(109, 213);
            this.copy_path.Name = "copy_path";
            this.copy_path.Size = new System.Drawing.Size(31, 13);
            this.copy_path.TabIndex = 19;
            this.copy_path.Text = "C:\\...";
            // 
            // save_structure
            // 
            this.save_structure.AutoSize = true;
            this.save_structure.Location = new System.Drawing.Point(12, 237);
            this.save_structure.Name = "save_structure";
            this.save_structure.Size = new System.Drawing.Size(101, 17);
            this.save_structure.TabIndex = 21;
            this.save_structure.Text = "Save structure?";
            this.save_structure.UseVisualStyleBackColor = true;
            this.save_structure.CheckedChanged += new System.EventHandler(this.Save_structure_CheckedChanged);
            // 
            // start_copying
            // 
            this.start_copying.Location = new System.Drawing.Point(12, 289);
            this.start_copying.Name = "start_copying";
            this.start_copying.Size = new System.Drawing.Size(509, 23);
            this.start_copying.TabIndex = 22;
            this.start_copying.Text = "Start Copying";
            this.start_copying.UseVisualStyleBackColor = true;
            this.start_copying.Click += new System.EventHandler(this.Start_copying_Click);
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 324);
            this.Controls.Add(this.start_copying);
            this.Controls.Add(this.save_structure);
            this.Controls.Add(this.copy_path_button);
            this.Controls.Add(this.copy_path);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.filter_text);
            this.Controls.Add(this.to_creation_date_pickup);
            this.Controls.Add(this.from_creation_date_pickup);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.to_modify_date_pickup);
            this.Controls.Add(this.from_modify_date_pickup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.select_file_type);
            this.Controls.Add(this.load_path_button);
            this.Controls.Add(this.load_path);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainFrom";
            this.Text = "Copy Files Structure";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label load_path;
        private System.Windows.Forms.Button load_path_button;
        private System.Windows.Forms.ComboBox select_file_type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker from_modify_date_pickup;
        private System.Windows.Forms.DateTimePicker to_modify_date_pickup;
        private System.Windows.Forms.DateTimePicker to_creation_date_pickup;
        private System.Windows.Forms.DateTimePicker from_creation_date_pickup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox filter_text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button copy_path_button;
        private System.Windows.Forms.Label copy_path;
        private System.Windows.Forms.CheckBox save_structure;
        private System.Windows.Forms.Button start_copying;
    }
}

