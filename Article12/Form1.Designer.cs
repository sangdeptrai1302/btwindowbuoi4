
namespace Article12
{
    partial class Form1
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
            this.cb_faculty = new System.Windows.Forms.ComboBox();
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.btClear = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_faculty
            // 
            this.cb_faculty.FormattingEnabled = true;
            this.cb_faculty.Items.AddRange(new object[] {
            "Công nghệ thông tin ",
            "ngoại ngữ",
            "quản trị kinh doanh",
            "cơ khí",
            "Điện",
            "cơ khí động lực",
            ""});
            this.cb_faculty.Location = new System.Drawing.Point(27, 12);
            this.cb_faculty.Name = "cb_faculty";
            this.cb_faculty.Size = new System.Drawing.Size(207, 21);
            this.cb_faculty.TabIndex = 0;
            this.cb_faculty.SelectedIndexChanged += new System.EventHandler(this.cb_faculty_SelectedIndexChanged);
            // 
            // tbDisplay
            // 
            this.tbDisplay.Location = new System.Drawing.Point(27, 39);
            this.tbDisplay.Multiline = true;
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.Size = new System.Drawing.Size(207, 179);
            this.tbDisplay.TabIndex = 2;
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(81, 224);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 3;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(182, 224);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(52, 23);
            this.btOk.TabIndex = 4;
            this.btOk.Text = "ok";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 255);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.tbDisplay);
            this.Controls.Add(this.cb_faculty);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_faculty;
        private System.Windows.Forms.TextBox tbDisplay;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btOk;
    }
}

