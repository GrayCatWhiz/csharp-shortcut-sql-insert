namespace test_program
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
            this.name = new System.Windows.Forms.TextBox();
            this.insertBtn = new System.Windows.Forms.Button();
            this.age = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(47, 36);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(274, 20);
            this.name.TabIndex = 0;
            // 
            // insertBtn
            // 
            this.insertBtn.Location = new System.Drawing.Point(47, 194);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(263, 23);
            this.insertBtn.TabIndex = 1;
            this.insertBtn.Text = "Insert";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(47, 74);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(274, 20);
            this.age.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 289);
            this.Controls.Add(this.age);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.name);
            this.Name = "Form1";
            this.Text = "Dynamic Insert Query Method Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.TextBox age;
    }
}

