namespace CSC202_Moonbase_Alpha_First_Simulation
{
    partial class FormMain
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
            this.GBlocation = new System.Windows.Forms.GroupBox();
            this.labelRoomDescription = new System.Windows.Forms.Label();
            this.TBcontrolcenter = new System.Windows.Forms.TextBox();
            this.BTNabout = new System.Windows.Forms.Button();
            this.GBlocation.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBlocation
            // 
            this.GBlocation.BackColor = System.Drawing.Color.Silver;
            this.GBlocation.Controls.Add(this.BTNabout);
            this.GBlocation.Controls.Add(this.TBcontrolcenter);
            this.GBlocation.Controls.Add(this.labelRoomDescription);
            this.GBlocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBlocation.Location = new System.Drawing.Point(105, 318);
            this.GBlocation.Name = "GBlocation";
            this.GBlocation.Size = new System.Drawing.Size(231, 131);
            this.GBlocation.TabIndex = 0;
            this.GBlocation.TabStop = false;
            this.GBlocation.Text = "Location Information";
            // 
            // labelRoomDescription
            // 
            this.labelRoomDescription.AutoSize = true;
            this.labelRoomDescription.BackColor = System.Drawing.Color.IndianRed;
            this.labelRoomDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoomDescription.ForeColor = System.Drawing.Color.Navy;
            this.labelRoomDescription.Location = new System.Drawing.Point(6, 31);
            this.labelRoomDescription.Name = "labelRoomDescription";
            this.labelRoomDescription.Size = new System.Drawing.Size(111, 16);
            this.labelRoomDescription.TabIndex = 0;
            this.labelRoomDescription.Text = "Command Center";
            // 
            // TBcontrolcenter
            // 
            this.TBcontrolcenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBcontrolcenter.Location = new System.Drawing.Point(9, 64);
            this.TBcontrolcenter.Name = "TBcontrolcenter";
            this.TBcontrolcenter.ReadOnly = true;
            this.TBcontrolcenter.Size = new System.Drawing.Size(185, 20);
            this.TBcontrolcenter.TabIndex = 1;
            this.TBcontrolcenter.Text = "Moonbase Alpha Control Center";
            // 
            // BTNabout
            // 
            this.BTNabout.BackColor = System.Drawing.Color.Black;
            this.BTNabout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNabout.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTNabout.Location = new System.Drawing.Point(9, 91);
            this.BTNabout.Name = "BTNabout";
            this.BTNabout.Size = new System.Drawing.Size(70, 23);
            this.BTNabout.TabIndex = 2;
            this.BTNabout.Text = "About";
            this.BTNabout.UseVisualStyleBackColor = false;
            this.BTNabout.Click += new System.EventHandler(this.BTNabout_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CSC202_Moonbase_Alpha_First_Simulation.Properties.Resources.Future_Lunar_Command_Room;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 985);
            this.Controls.Add(this.GBlocation);
            this.Name = "FormMain";
            this.Text = "Moonbase Command";
            this.GBlocation.ResumeLayout(false);
            this.GBlocation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBlocation;
        private System.Windows.Forms.Label labelRoomDescription;
        private System.Windows.Forms.TextBox TBcontrolcenter;
        private System.Windows.Forms.Button BTNabout;
    }
}

