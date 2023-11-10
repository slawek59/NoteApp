﻿namespace NoteTakingApp
{
    partial class NoteTaker
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.previousNotes = new System.Windows.Forms.DataGridView();
            this.loadButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.newNoteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.previousNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(404, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(384, 26);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(404, 98);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(384, 340);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(400, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(400, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(388, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Note:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // previousNotes
            // 
            this.previousNotes.BackgroundColor = System.Drawing.Color.White;
            this.previousNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.previousNotes.Location = new System.Drawing.Point(12, 12);
            this.previousNotes.Name = "previousNotes";
            this.previousNotes.RowHeadersWidth = 62;
            this.previousNotes.RowTemplate.Height = 28;
            this.previousNotes.Size = new System.Drawing.Size(382, 347);
            this.previousNotes.TabIndex = 4;
            // 
            // loadButton
            // 
            this.loadButton.BackColor = System.Drawing.Color.White;
            this.loadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loadButton.Location = new System.Drawing.Point(8, 365);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(192, 37);
            this.loadButton.TabIndex = 5;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = false;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.White;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteButton.Location = new System.Drawing.Point(206, 365);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(192, 37);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.White;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveButton.Location = new System.Drawing.Point(206, 408);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(192, 37);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // newNoteButton
            // 
            this.newNoteButton.BackColor = System.Drawing.Color.White;
            this.newNoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newNoteButton.Location = new System.Drawing.Point(8, 408);
            this.newNoteButton.Name = "newNoteButton";
            this.newNoteButton.Size = new System.Drawing.Size(192, 37);
            this.newNoteButton.TabIndex = 8;
            this.newNoteButton.Text = "New Note";
            this.newNoteButton.UseVisualStyleBackColor = false;
            this.newNoteButton.Click += new System.EventHandler(this.newNoteButton_Click);
            // 
            // NoteTaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newNoteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.previousNotes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "NoteTaker";
            this.Text = "Note Taker";
            this.Load += new System.EventHandler(this.NoteTaker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.previousNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView previousNotes;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button newNoteButton;
    }
}

