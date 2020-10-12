namespace Alison_Govender_18010831_GADE6212_Task_1
{
    partial class GoblimsGame_Frm
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
            this.Tile_Lbl = new System.Windows.Forms.Label();
            this.Game_txtbox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Tile_Lbl
            // 
            this.Tile_Lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tile_Lbl.Location = new System.Drawing.Point(59, 30);
            this.Tile_Lbl.Name = "Tile_Lbl";
            this.Tile_Lbl.Size = new System.Drawing.Size(257, 379);
            this.Tile_Lbl.TabIndex = 0;
            // 
            // Game_txtbox
            // 
            this.Game_txtbox.Location = new System.Drawing.Point(366, 28);
            this.Game_txtbox.Name = "Game_txtbox";
            this.Game_txtbox.Size = new System.Drawing.Size(411, 258);
            this.Game_txtbox.TabIndex = 1;
            this.Game_txtbox.Text = "";
            // 
            // GoblimsGame_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Game_txtbox);
            this.Controls.Add(this.Tile_Lbl);
            this.Name = "GoblimsGame_Frm";
            this.Text = "Goblim game";
            this.Load += new System.EventHandler(this.GoblimsGame_Frm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Tile_Lbl;
        private System.Windows.Forms.RichTextBox Game_txtbox;
    }
}

