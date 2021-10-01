
namespace PDF_Single_Page_Booklet_Tiling
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
            this.TextBox_SourcePath = new System.Windows.Forms.TextBox();
            this.Label_SourcePath = new System.Windows.Forms.Label();
            this.Label_DestinationPath = new System.Windows.Forms.Label();
            this.TextBox_DestinationPath = new System.Windows.Forms.TextBox();
            this.Button_TilePDF = new System.Windows.Forms.Button();
            this.TextBox_Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TextBox_SourcePath
            // 
            this.TextBox_SourcePath.Location = new System.Drawing.Point(109, 14);
            this.TextBox_SourcePath.Name = "TextBox_SourcePath";
            this.TextBox_SourcePath.Size = new System.Drawing.Size(400, 23);
            this.TextBox_SourcePath.TabIndex = 1;
            this.TextBox_SourcePath.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Label_SourcePath
            // 
            this.Label_SourcePath.AutoSize = true;
            this.Label_SourcePath.Location = new System.Drawing.Point(27, 18);
            this.Label_SourcePath.Name = "Label_SourcePath";
            this.Label_SourcePath.Size = new System.Drawing.Size(76, 15);
            this.Label_SourcePath.TabIndex = 2;
            this.Label_SourcePath.Text = "Source Path: ";
            // 
            // Label_DestinationPath
            // 
            this.Label_DestinationPath.AutoSize = true;
            this.Label_DestinationPath.Location = new System.Drawing.Point(27, 50);
            this.Label_DestinationPath.Name = "Label_DestinationPath";
            this.Label_DestinationPath.Size = new System.Drawing.Size(100, 15);
            this.Label_DestinationPath.TabIndex = 3;
            this.Label_DestinationPath.Text = "Destination Path: ";
            this.Label_DestinationPath.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextBox_DestinationPath
            // 
            this.TextBox_DestinationPath.Location = new System.Drawing.Point(132, 46);
            this.TextBox_DestinationPath.Name = "TextBox_DestinationPath";
            this.TextBox_DestinationPath.Size = new System.Drawing.Size(377, 23);
            this.TextBox_DestinationPath.TabIndex = 4;
            // 
            // Button_TilePDF
            // 
            this.Button_TilePDF.Location = new System.Drawing.Point(25, 80);
            this.Button_TilePDF.Name = "Button_TilePDF";
            this.Button_TilePDF.Size = new System.Drawing.Size(485, 23);
            this.Button_TilePDF.TabIndex = 5;
            this.Button_TilePDF.Text = "Tile PDF";
            this.Button_TilePDF.UseVisualStyleBackColor = true;
            this.Button_TilePDF.Click += new System.EventHandler(this.Button_TilePDF_Click);
            // 
            // TextBox_Result
            // 
            this.TextBox_Result.Location = new System.Drawing.Point(25, 120);
            this.TextBox_Result.Name = "TextBox_Result";
            this.TextBox_Result.ReadOnly = true;
            this.TextBox_Result.Size = new System.Drawing.Size(485, 80);
            this.TextBox_Result.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.TextBox_Result);
            this.Controls.Add(this.Button_TilePDF);
            this.Controls.Add(this.TextBox_DestinationPath);
            this.Controls.Add(this.Label_DestinationPath);
            this.Controls.Add(this.Label_SourcePath);
            this.Controls.Add(this.TextBox_SourcePath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_SourcePath;
        private System.Windows.Forms.Label Label_SourcePath;
        private System.Windows.Forms.Label Label_DestinationPath;
        private System.Windows.Forms.TextBox TextBox_DestinationPath;
        private System.Windows.Forms.Button Button_TilePDF;
        private System.Windows.Forms.TextBox TextBox_Result;
    }
}

