namespace Where_Am_I
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.LocateBtn = new System.Windows.Forms.Button();
            this.costumeBtn = new System.Windows.Forms.Button();
            this.txtLangitude = new System.Windows.Forms.TextBox();
            this.longitudeLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.latitudeLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.LocateBtn);
            this.splitContainer1.Panel1.Controls.Add(this.costumeBtn);
            this.splitContainer1.Panel1.Controls.Add(this.txtLangitude);
            this.splitContainer1.Panel1.Controls.Add(this.longitudeLbl);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtLatitude);
            this.splitContainer1.Panel1.Controls.Add(this.latitudeLbl);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.map);
            this.splitContainer1.Size = new System.Drawing.Size(1295, 726);
            this.splitContainer1.SplitterDistance = 431;
            this.splitContainer1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Costume search :";
            // 
            // LocateBtn
            // 
            this.LocateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LocateBtn.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocateBtn.Location = new System.Drawing.Point(80, 164);
            this.LocateBtn.Name = "LocateBtn";
            this.LocateBtn.Size = new System.Drawing.Size(249, 64);
            this.LocateBtn.TabIndex = 4;
            this.LocateBtn.Text = "Locate Me";
            this.LocateBtn.UseVisualStyleBackColor = true;
            this.LocateBtn.Click += new System.EventHandler(this.LocateBtn_Click);
            // 
            // costumeBtn
            // 
            this.costumeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.costumeBtn.Font = new System.Drawing.Font("Candara", 12F);
            this.costumeBtn.Location = new System.Drawing.Point(80, 639);
            this.costumeBtn.Name = "costumeBtn";
            this.costumeBtn.Size = new System.Drawing.Size(249, 41);
            this.costumeBtn.TabIndex = 3;
            this.costumeBtn.Text = "Submit";
            this.costumeBtn.UseVisualStyleBackColor = true;
            this.costumeBtn.Click += new System.EventHandler(this.costumeBtn_Click);
            // 
            // txtLangitude
            // 
            this.txtLangitude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLangitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLangitude.Location = new System.Drawing.Point(80, 563);
            this.txtLangitude.Name = "txtLangitude";
            this.txtLangitude.Size = new System.Drawing.Size(249, 28);
            this.txtLangitude.TabIndex = 2;
            // 
            // longitudeLbl
            // 
            this.longitudeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.longitudeLbl.AutoSize = true;
            this.longitudeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longitudeLbl.Location = new System.Drawing.Point(75, 517);
            this.longitudeLbl.Name = "longitudeLbl";
            this.longitudeLbl.Size = new System.Drawing.Size(109, 25);
            this.longitudeLbl.TabIndex = 1;
            this.longitudeLbl.Text = "Langitude :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Subrayada", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "WHERE AM I";
            // 
            // txtLatitude
            // 
            this.txtLatitude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLatitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLatitude.Location = new System.Drawing.Point(80, 456);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(249, 28);
            this.txtLatitude.TabIndex = 2;
            // 
            // latitudeLbl
            // 
            this.latitudeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.latitudeLbl.AutoSize = true;
            this.latitudeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latitudeLbl.Location = new System.Drawing.Point(75, 403);
            this.latitudeLbl.Name = "latitudeLbl";
            this.latitudeLbl.Size = new System.Drawing.Size(92, 25);
            this.latitudeLbl.TabIndex = 1;
            this.latitudeLbl.Text = "Latitude :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "label1";
            // 
            // map
            // 
            this.map.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(15, 12);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(833, 702);
            this.map.TabIndex = 0;
            this.map.Zoom = 0D;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 726);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(1000, 750);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button LocateBtn;
        private System.Windows.Forms.Button costumeBtn;
        private System.Windows.Forms.TextBox txtLangitude;
        private System.Windows.Forms.Label longitudeLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.Label latitudeLbl;
        private System.Windows.Forms.Label label4;
        private GMap.NET.WindowsForms.GMapControl map;
        
        private System.Windows.Forms.Label label2;
    }
}

