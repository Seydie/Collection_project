namespace Collection_project
{
    partial class collection_form
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
            this.test = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(38, 48);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(100, 22);
            this.test.TabIndex = 0;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(38, 105);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(171, 17);
            this.label.TabIndex = 1;
            this.label.Text = "Hier komt een andere text";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // collection_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 462);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.test);
            this.Name = "collection_form";
            this.Text = "My Collection";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.collection_form_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox test;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button button1;
    }
}

