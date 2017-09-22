namespace BeerocracyWindowsApp
{
	partial class frmCreate
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
            this.components = new System.ComponentModel.Container();
            this.dsBeerocracy = new BeerocracyWindowsApp.dsBeerocracy();
            this.ingredientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ingredientTableAdapter = new BeerocracyWindowsApp.dsBeerocracyTableAdapters.IngredientTableAdapter();
            this.lbIngredient = new System.Windows.Forms.ListBox();
            this.lblSelectIng = new System.Windows.Forms.Label();
            this.lblDontSee = new System.Windows.Forms.Label();
            this.txtNewIng = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblNameBeer = new System.Windows.Forms.Label();
            this.txtNewBeer = new System.Windows.Forms.TextBox();
            this.beerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beerTableAdapter = new BeerocracyWindowsApp.dsBeerocracyTableAdapters.BeerTableAdapter();
            this.beerIngredientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBeerocracy1 = new BeerocracyWindowsApp.dsBeerocracy();
            this.beerIngredientTableAdapter = new BeerocracyWindowsApp.dsBeerocracyTableAdapters.BeerIngredientTableAdapter();
            this.dsBeerocracyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ddBeer = new Telerik.WinControls.UI.RadDropDownList();
            this.lblWelcome = new Telerik.WinControls.UI.RadLabel();
            this.pnlMain = new Telerik.WinControls.UI.RadPanel();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.txtDisplayIng = new Telerik.WinControls.UI.RadRichTextEditor();
            this.lblCreate = new Telerik.WinControls.UI.RadLabel();
            this.roundRectShape1 = new Telerik.WinControls.RoundRectShape(this.components);
            this.pnlSearch = new Telerik.WinControls.UI.RadPanel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.lblIngredients = new Telerik.WinControls.UI.RadLabel();
            this.txtIng = new Telerik.WinControls.UI.RadRichTextEditor();
            this.lblSearch = new Telerik.WinControls.UI.RadLabel();
            this.chamferedRectShape1 = new Telerik.WinControls.ChamferedRectShape();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.office2007BlackTheme1 = new Telerik.WinControls.Themes.Office2007BlackTheme();
            ((System.ComponentModel.ISupportInitialize)(this.dsBeerocracy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beerIngredientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBeerocracy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBeerocracyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddBeer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblWelcome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDisplayIng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCreate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearch)).BeginInit();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblIngredients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dsBeerocracy
            // 
            this.dsBeerocracy.DataSetName = "dsBeerocracy";
            this.dsBeerocracy.EnforceConstraints = false;
            this.dsBeerocracy.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ingredientBindingSource
            // 
            this.ingredientBindingSource.DataMember = "Ingredient";
            this.ingredientBindingSource.DataSource = this.dsBeerocracy;
            // 
            // ingredientTableAdapter
            // 
            this.ingredientTableAdapter.ClearBeforeFill = true;
            // 
            // lbIngredient
            // 
            this.lbIngredient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbIngredient.DataSource = this.ingredientBindingSource;
            this.lbIngredient.DisplayMember = "IngredientName";
            this.lbIngredient.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lbIngredient.ForeColor = System.Drawing.Color.Black;
            this.lbIngredient.FormattingEnabled = true;
            this.lbIngredient.Location = new System.Drawing.Point(183, 96);
            this.lbIngredient.Name = "lbIngredient";
            this.lbIngredient.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbIngredient.Size = new System.Drawing.Size(119, 169);
            this.lbIngredient.Sorted = true;
            this.lbIngredient.TabIndex = 1;
            this.lbIngredient.ValueMember = "IngredientID";
            this.lbIngredient.SelectedIndexChanged += new System.EventHandler(this.lbIngredient_SelectedIndexChanged);
            // 
            // lblSelectIng
            // 
            this.lblSelectIng.AutoSize = true;
            this.lblSelectIng.Location = new System.Drawing.Point(15, 96);
            this.lblSelectIng.Name = "lblSelectIng";
            this.lblSelectIng.Size = new System.Drawing.Size(143, 13);
            this.lblSelectIng.TabIndex = 0;
            this.lblSelectIng.Text = "1.  Select your ingredients:";
            // 
            // lblDontSee
            // 
            this.lblDontSee.AutoSize = true;
            this.lblDontSee.Location = new System.Drawing.Point(15, 334);
            this.lblDontSee.Name = "lblDontSee";
            this.lblDontSee.Size = new System.Drawing.Size(251, 13);
            this.lblDontSee.TabIndex = 0;
            this.lblDontSee.Text = "2.  Don\'t see your ingredient?  Add it to the list!";
            // 
            // txtNewIng
            // 
            this.txtNewIng.Location = new System.Drawing.Point(272, 327);
            this.txtNewIng.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.txtNewIng.Name = "txtNewIng";
            this.txtNewIng.Size = new System.Drawing.Size(155, 20);
            this.txtNewIng.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(352, 370);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(352, 459);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 3, 3, 50);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblNameBeer
            // 
            this.lblNameBeer.AutoSize = true;
            this.lblNameBeer.Location = new System.Drawing.Point(15, 423);
            this.lblNameBeer.Name = "lblNameBeer";
            this.lblNameBeer.Size = new System.Drawing.Size(106, 13);
            this.lblNameBeer.TabIndex = 0;
            this.lblNameBeer.Text = "3.  Name your beer:";
            // 
            // txtNewBeer
            // 
            this.txtNewBeer.Location = new System.Drawing.Point(272, 416);
            this.txtNewBeer.Margin = new System.Windows.Forms.Padding(3, 3, 3, 50);
            this.txtNewBeer.Name = "txtNewBeer";
            this.txtNewBeer.Size = new System.Drawing.Size(155, 20);
            this.txtNewBeer.TabIndex = 4;
            // 
            // beerBindingSource
            // 
            this.beerBindingSource.DataMember = "Beer";
            this.beerBindingSource.DataSource = this.dsBeerocracy;
            // 
            // beerTableAdapter
            // 
            this.beerTableAdapter.ClearBeforeFill = true;
            // 
            // beerIngredientBindingSource
            // 
            this.beerIngredientBindingSource.DataMember = "BeerIngredient";
            this.beerIngredientBindingSource.DataSource = this.dsBeerocracy1;
            // 
            // dsBeerocracy1
            // 
            this.dsBeerocracy1.DataSetName = "dsBeerocracy";
            this.dsBeerocracy1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // beerIngredientTableAdapter
            // 
            this.beerIngredientTableAdapter.ClearBeforeFill = true;
            // 
            // dsBeerocracyBindingSource
            // 
            this.dsBeerocracyBindingSource.DataSource = this.dsBeerocracy;
            this.dsBeerocracyBindingSource.Position = 0;
            // 
            // ddBeer
            // 
            this.ddBeer.DataSource = this.beerBindingSource;
            this.ddBeer.DisplayMember = "BeerName";
            this.ddBeer.DropDownAnimationEnabled = false;
            this.ddBeer.Location = new System.Drawing.Point(148, 94);
            this.ddBeer.Name = "ddBeer";
            this.ddBeer.Size = new System.Drawing.Size(155, 20);
            this.ddBeer.TabIndex = 9;
            this.ddBeer.ValueMember = "BeerID";
            this.ddBeer.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.ddBeer_SelectedIndexChanged);
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.Location = new System.Drawing.Point(28, 18);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(807, 21);
            this.lblWelcome.TabIndex = 10;
            this.lblWelcome.Text = "Welcome to the Homebrew Toolkit!  Here you can search award-winning beer recipes " +
    "and create your very own beer recipe!";
            this.lblWelcome.ThemeName = "Office2007Black";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.radPanel1);
            this.pnlMain.Controls.Add(this.lblWelcome);
            this.pnlMain.EnableTheming = false;
            this.pnlMain.Location = new System.Drawing.Point(22, 9);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(913, 604);
            this.pnlMain.TabIndex = 11;
            this.pnlMain.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.pnlMain.GetChildAt(0).GetChildAt(1))).Shape = this.roundRectShape1;
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.txtDisplayIng);
            this.radPanel1.Controls.Add(this.lblCreate);
            this.radPanel1.Controls.Add(this.lblSelectIng);
            this.radPanel1.Controls.Add(this.lbIngredient);
            this.radPanel1.Controls.Add(this.btnSave);
            this.radPanel1.Controls.Add(this.txtNewBeer);
            this.radPanel1.Controls.Add(this.lblDontSee);
            this.radPanel1.Controls.Add(this.lblNameBeer);
            this.radPanel1.Controls.Add(this.txtNewIng);
            this.radPanel1.Controls.Add(this.btnAdd);
            this.radPanel1.EnableTheming = false;
            this.radPanel1.Location = new System.Drawing.Point(405, 61);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Padding = new System.Windows.Forms.Padding(2);
            this.radPanel1.Size = new System.Drawing.Size(441, 523);
            this.radPanel1.TabIndex = 13;
            ((Telerik.WinControls.UI.RadPanelElement)(this.radPanel1.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(2);
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(1))).Shape = this.roundRectShape1;
            // 
            // txtDisplayIng
            // 
            this.txtDisplayIng.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(189)))), ((int)(((byte)(232)))));
            this.txtDisplayIng.DocumentInheritsDefaultStyleSettings = true;
            this.txtDisplayIng.EnableTheming = false;
            this.txtDisplayIng.IsReadOnly = true;
            this.txtDisplayIng.Location = new System.Drawing.Point(308, 96);
            this.txtDisplayIng.Name = "txtDisplayIng";
            this.txtDisplayIng.SelectionFill = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(78)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtDisplayIng.Size = new System.Drawing.Size(119, 169);
            this.txtDisplayIng.TabIndex = 12;
            // 
            // lblCreate
            // 
            this.lblCreate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCreate.Location = new System.Drawing.Point(18, 35);
            this.lblCreate.Name = "lblCreate";
            this.lblCreate.Size = new System.Drawing.Size(150, 21);
            this.lblCreate.TabIndex = 11;
            this.lblCreate.Text = "Create your own beer!";
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.radLabel1);
            this.pnlSearch.Controls.Add(this.lblIngredients);
            this.pnlSearch.Controls.Add(this.txtIng);
            this.pnlSearch.Controls.Add(this.lblSearch);
            this.pnlSearch.Controls.Add(this.ddBeer);
            this.pnlSearch.EnableTheming = false;
            this.pnlSearch.Location = new System.Drawing.Point(50, 70);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(353, 523);
            this.pnlSearch.TabIndex = 12;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.pnlSearch.GetChildAt(0).GetChildAt(1))).Shape = this.roundRectShape1;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(19, 96);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(47, 18);
            this.radLabel1.TabIndex = 13;
            this.radLabel1.Text = "Recipes:";
            // 
            // lblIngredients
            // 
            this.lblIngredients.Location = new System.Drawing.Point(19, 139);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(65, 18);
            this.lblIngredients.TabIndex = 12;
            this.lblIngredients.Text = "Ingredients:";
            // 
            // txtIng
            // 
            this.txtIng.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(189)))), ((int)(((byte)(232)))));
            this.txtIng.DocumentInheritsDefaultStyleSettings = true;
            this.txtIng.EnableTheming = false;
            this.txtIng.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtIng.IsReadOnly = true;
            this.txtIng.Location = new System.Drawing.Point(148, 139);
            this.txtIng.Name = "txtIng";
            // 
            // 
            // 
            this.txtIng.RootElement.ApplyShapeToControl = true;
            this.txtIng.SelectionFill = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(78)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtIng.Size = new System.Drawing.Size(155, 226);
            this.txtIng.TabIndex = 11;
            ((Telerik.WinForms.RichTextEditor.RadRichTextBox)(this.txtIng.GetChildAt(0))).BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(189)))), ((int)(((byte)(232)))));
            ((Telerik.WinForms.RichTextEditor.RadRichTextBox)(this.txtIng.GetChildAt(0))).SelectionFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(78)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            ((Telerik.WinForms.RichTextEditor.RadRichTextBox)(this.txtIng.GetChildAt(0))).IsReadOnly = true;
            ((Telerik.WinForms.RichTextEditor.RadRichTextBox)(this.txtIng.GetChildAt(0))).DocumentInheritsDefaultStyleSettings = true;
            ((Telerik.WinForms.RichTextEditor.RadRichTextBox)(this.txtIng.GetChildAt(0))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            ((Telerik.WinForms.RichTextEditor.RadRichTextBox)(this.txtIng.GetChildAt(0))).Font = new System.Drawing.Font("Segoe UI", 8.25F);
            // 
            // lblSearch
            // 
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSearch.Location = new System.Drawing.Point(19, 35);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(107, 21);
            this.lblSearch.TabIndex = 10;
            this.lblSearch.Text = "Search Recipes!";
            // 
            // frmCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 880);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.HelpButton = true;
            this.Name = "frmCreate";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Homebrew Toolkit";
            this.ThemeName = "Office2007Black";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsBeerocracy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beerIngredientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBeerocracy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBeerocracyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddBeer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblWelcome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDisplayIng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCreate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearch)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblIngredients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private dsBeerocracy dsBeerocracy;
		private System.Windows.Forms.BindingSource ingredientBindingSource;
		private dsBeerocracyTableAdapters.IngredientTableAdapter ingredientTableAdapter;
		private System.Windows.Forms.ListBox lbIngredient;
		private System.Windows.Forms.Label lblSelectIng;
		private System.Windows.Forms.Label lblDontSee;
		private System.Windows.Forms.TextBox txtNewIng;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label lblNameBeer;
		private System.Windows.Forms.TextBox txtNewBeer;
		private System.Windows.Forms.BindingSource beerBindingSource;
		private dsBeerocracyTableAdapters.BeerTableAdapter beerTableAdapter;
		private System.Windows.Forms.BindingSource beerIngredientBindingSource;
		private dsBeerocracy dsBeerocracy1;
		private dsBeerocracyTableAdapters.BeerIngredientTableAdapter beerIngredientTableAdapter;
		private System.Windows.Forms.BindingSource dsBeerocracyBindingSource;
        private Telerik.WinControls.UI.RadDropDownList ddBeer;
        private Telerik.WinControls.UI.RadLabel lblWelcome;
        private Telerik.WinControls.UI.RadPanel pnlMain;
        private Telerik.WinControls.UI.RadPanel pnlSearch;
        private Telerik.WinControls.UI.RadLabel lblSearch;
        private Telerik.WinControls.RoundRectShape roundRectShape1;
        private Telerik.WinControls.ChamferedRectShape chamferedRectShape1;
        private Telerik.WinControls.UI.RadRichTextEditor txtIng;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadLabel lblCreate;
        private Telerik.WinControls.UI.RadRichTextEditor txtDisplayIng;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private Telerik.WinControls.Themes.Office2007BlackTheme office2007BlackTheme1;
        private Telerik.WinControls.UI.RadLabel lblIngredients;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}