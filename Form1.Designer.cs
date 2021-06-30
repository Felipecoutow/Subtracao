
namespace WindowsFormsApp1
{
    partial class frmSubtracao
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSubtracao));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.lblsub = new System.Windows.Forms.Label();
            this.lbln1 = new System.Windows.Forms.Label();
            this.lbln2 = new System.Windows.Forms.Label();
            this.grpbuttons = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnLimpar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSair = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtn2 = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtresultado = new Bunifu.UI.WinForms.BunifuTextBox();
            this.lblresultado = new System.Windows.Forms.Label();
            this.txtn1 = new Bunifu.UI.WinForms.BunifuTextBox();
            this.grpbuttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblsub
            // 
            this.lblsub.AutoSize = true;
            this.lblsub.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsub.Location = new System.Drawing.Point(57, 42);
            this.lblsub.Name = "lblsub";
            this.lblsub.Size = new System.Drawing.Size(95, 22);
            this.lblsub.TabIndex = 0;
            this.lblsub.Text = "Subtração";
            // 
            // lbln1
            // 
            this.lbln1.AutoSize = true;
            this.lbln1.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbln1.Location = new System.Drawing.Point(57, 73);
            this.lbln1.Name = "lbln1";
            this.lbln1.Size = new System.Drawing.Size(92, 22);
            this.lbln1.TabIndex = 1;
            this.lbln1.Text = "Número 1:";
            // 
            // lbln2
            // 
            this.lbln2.AutoSize = true;
            this.lbln2.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbln2.Location = new System.Drawing.Point(57, 160);
            this.lbln2.Name = "lbln2";
            this.lbln2.Size = new System.Drawing.Size(95, 22);
            this.lbln2.TabIndex = 2;
            this.lbln2.Text = "Número 2:";
            // 
            // grpbuttons
            // 
            this.grpbuttons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grpbuttons.Controls.Add(this.btnSair);
            this.grpbuttons.Controls.Add(this.btnLimpar);
            this.grpbuttons.Controls.Add(this.btnCalcular);
            this.grpbuttons.ForeColor = System.Drawing.Color.Transparent;
            this.grpbuttons.Location = new System.Drawing.Point(408, 73);
            this.grpbuttons.Name = "grpbuttons";
            this.grpbuttons.Size = new System.Drawing.Size(200, 290);
            this.grpbuttons.TabIndex = 3;
            this.grpbuttons.TabStop = false;
            // 
            // btnCalcular
            // 
            this.btnCalcular.AllowAnimations = true;
            this.btnCalcular.AllowMouseEffects = true;
            this.btnCalcular.AllowToggling = false;
            this.btnCalcular.AnimationSpeed = 200;
            this.btnCalcular.AutoGenerateColors = false;
            this.btnCalcular.AutoRoundBorders = false;
            this.btnCalcular.AutoSizeLeftIcon = true;
            this.btnCalcular.AutoSizeRightIcon = true;
            this.btnCalcular.BackColor = System.Drawing.Color.Transparent;
            this.btnCalcular.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnCalcular.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalcular.BackgroundImage")));
            this.btnCalcular.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCalcular.ButtonText = "Calcular";
            this.btnCalcular.ButtonTextMarginLeft = 0;
            this.btnCalcular.ColorContrastOnClick = 45;
            this.btnCalcular.ColorContrastOnHover = 45;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnCalcular.CustomizableEdges = borderEdges3;
            this.btnCalcular.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCalcular.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCalcular.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCalcular.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCalcular.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcular.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCalcular.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnCalcular.IconMarginLeft = 11;
            this.btnCalcular.IconPadding = 10;
            this.btnCalcular.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalcular.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCalcular.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCalcular.IconSize = 25;
            this.btnCalcular.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCalcular.IdleBorderRadius = 25;
            this.btnCalcular.IdleBorderThickness = 1;
            this.btnCalcular.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnCalcular.IdleIconLeftImage = null;
            this.btnCalcular.IdleIconRightImage = null;
            this.btnCalcular.IndicateFocus = false;
            this.btnCalcular.Location = new System.Drawing.Point(22, 39);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCalcular.OnDisabledState.BorderRadius = 25;
            this.btnCalcular.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCalcular.OnDisabledState.BorderThickness = 1;
            this.btnCalcular.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCalcular.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCalcular.OnDisabledState.IconLeftImage = null;
            this.btnCalcular.OnDisabledState.IconRightImage = null;
            this.btnCalcular.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnCalcular.onHoverState.BorderRadius = 25;
            this.btnCalcular.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCalcular.onHoverState.BorderThickness = 1;
            this.btnCalcular.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnCalcular.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.onHoverState.IconLeftImage = null;
            this.btnCalcular.onHoverState.IconRightImage = null;
            this.btnCalcular.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCalcular.OnIdleState.BorderRadius = 25;
            this.btnCalcular.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCalcular.OnIdleState.BorderThickness = 1;
            this.btnCalcular.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnCalcular.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.OnIdleState.IconLeftImage = null;
            this.btnCalcular.OnIdleState.IconRightImage = null;
            this.btnCalcular.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCalcular.OnPressedState.BorderRadius = 25;
            this.btnCalcular.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCalcular.OnPressedState.BorderThickness = 1;
            this.btnCalcular.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCalcular.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.OnPressedState.IconLeftImage = null;
            this.btnCalcular.OnPressedState.IconRightImage = null;
            this.btnCalcular.Size = new System.Drawing.Size(150, 39);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCalcular.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCalcular.TextMarginLeft = 0;
            this.btnCalcular.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCalcular.UseDefaultRadiusAndThickness = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.AllowAnimations = true;
            this.btnLimpar.AllowMouseEffects = true;
            this.btnLimpar.AllowToggling = false;
            this.btnLimpar.AnimationSpeed = 200;
            this.btnLimpar.AutoGenerateColors = false;
            this.btnLimpar.AutoRoundBorders = false;
            this.btnLimpar.AutoSizeLeftIcon = true;
            this.btnLimpar.AutoSizeRightIcon = true;
            this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnLimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpar.BackgroundImage")));
            this.btnLimpar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLimpar.ButtonText = "Limpar";
            this.btnLimpar.ButtonTextMarginLeft = 0;
            this.btnLimpar.ColorContrastOnClick = 45;
            this.btnLimpar.ColorContrastOnHover = 45;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnLimpar.CustomizableEdges = borderEdges2;
            this.btnLimpar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLimpar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLimpar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLimpar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLimpar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnLimpar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnLimpar.IconMarginLeft = 11;
            this.btnLimpar.IconPadding = 10;
            this.btnLimpar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnLimpar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnLimpar.IconSize = 25;
            this.btnLimpar.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnLimpar.IdleBorderRadius = 25;
            this.btnLimpar.IdleBorderThickness = 1;
            this.btnLimpar.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnLimpar.IdleIconLeftImage = null;
            this.btnLimpar.IdleIconRightImage = null;
            this.btnLimpar.IndicateFocus = false;
            this.btnLimpar.Location = new System.Drawing.Point(25, 114);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLimpar.OnDisabledState.BorderRadius = 25;
            this.btnLimpar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLimpar.OnDisabledState.BorderThickness = 1;
            this.btnLimpar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLimpar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLimpar.OnDisabledState.IconLeftImage = null;
            this.btnLimpar.OnDisabledState.IconRightImage = null;
            this.btnLimpar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnLimpar.onHoverState.BorderRadius = 25;
            this.btnLimpar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLimpar.onHoverState.BorderThickness = 1;
            this.btnLimpar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnLimpar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.onHoverState.IconLeftImage = null;
            this.btnLimpar.onHoverState.IconRightImage = null;
            this.btnLimpar.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnLimpar.OnIdleState.BorderRadius = 25;
            this.btnLimpar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLimpar.OnIdleState.BorderThickness = 1;
            this.btnLimpar.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnLimpar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.OnIdleState.IconLeftImage = null;
            this.btnLimpar.OnIdleState.IconRightImage = null;
            this.btnLimpar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnLimpar.OnPressedState.BorderRadius = 25;
            this.btnLimpar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLimpar.OnPressedState.BorderThickness = 1;
            this.btnLimpar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnLimpar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.OnPressedState.IconLeftImage = null;
            this.btnLimpar.OnPressedState.IconRightImage = null;
            this.btnLimpar.Size = new System.Drawing.Size(150, 39);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLimpar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLimpar.TextMarginLeft = 0;
            this.btnLimpar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnLimpar.UseDefaultRadiusAndThickness = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.AllowAnimations = true;
            this.btnSair.AllowMouseEffects = true;
            this.btnSair.AllowToggling = false;
            this.btnSair.AnimationSpeed = 200;
            this.btnSair.AutoGenerateColors = false;
            this.btnSair.AutoRoundBorders = false;
            this.btnSair.AutoSizeLeftIcon = true;
            this.btnSair.AutoSizeRightIcon = true;
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSair.ButtonText = "Sair";
            this.btnSair.ButtonTextMarginLeft = 0;
            this.btnSair.ColorContrastOnClick = 45;
            this.btnSair.ColorContrastOnHover = 45;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnSair.CustomizableEdges = borderEdges1;
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSair.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSair.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSair.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSair.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSair.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSair.IconMarginLeft = 11;
            this.btnSair.IconPadding = 10;
            this.btnSair.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSair.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSair.IconSize = 25;
            this.btnSair.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSair.IdleBorderRadius = 25;
            this.btnSair.IdleBorderThickness = 1;
            this.btnSair.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnSair.IdleIconLeftImage = null;
            this.btnSair.IdleIconRightImage = null;
            this.btnSair.IndicateFocus = false;
            this.btnSair.Location = new System.Drawing.Point(25, 189);
            this.btnSair.Name = "btnSair";
            this.btnSair.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSair.OnDisabledState.BorderRadius = 25;
            this.btnSair.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSair.OnDisabledState.BorderThickness = 1;
            this.btnSair.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSair.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSair.OnDisabledState.IconLeftImage = null;
            this.btnSair.OnDisabledState.IconRightImage = null;
            this.btnSair.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSair.onHoverState.BorderRadius = 25;
            this.btnSair.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSair.onHoverState.BorderThickness = 1;
            this.btnSair.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSair.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSair.onHoverState.IconLeftImage = null;
            this.btnSair.onHoverState.IconRightImage = null;
            this.btnSair.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSair.OnIdleState.BorderRadius = 25;
            this.btnSair.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSair.OnIdleState.BorderThickness = 1;
            this.btnSair.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnSair.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSair.OnIdleState.IconLeftImage = null;
            this.btnSair.OnIdleState.IconRightImage = null;
            this.btnSair.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSair.OnPressedState.BorderRadius = 25;
            this.btnSair.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSair.OnPressedState.BorderThickness = 1;
            this.btnSair.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSair.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSair.OnPressedState.IconLeftImage = null;
            this.btnSair.OnPressedState.IconRightImage = null;
            this.btnSair.Size = new System.Drawing.Size(150, 39);
            this.btnSair.TabIndex = 2;
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSair.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSair.TextMarginLeft = 0;
            this.btnSair.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSair.UseDefaultRadiusAndThickness = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtn2
            // 
            this.txtn2.AcceptsReturn = false;
            this.txtn2.AcceptsTab = false;
            this.txtn2.AnimationSpeed = 200;
            this.txtn2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtn2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtn2.BackColor = System.Drawing.Color.Transparent;
            this.txtn2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtn2.BackgroundImage")));
            this.txtn2.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtn2.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtn2.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtn2.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtn2.BorderRadius = 15;
            this.txtn2.BorderThickness = 1;
            this.txtn2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtn2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtn2.DefaultFont = new System.Drawing.Font("SF UI Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtn2.DefaultText = "";
            this.txtn2.FillColor = System.Drawing.Color.White;
            this.txtn2.HideSelection = true;
            this.txtn2.IconLeft = null;
            this.txtn2.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtn2.IconPadding = 10;
            this.txtn2.IconRight = null;
            this.txtn2.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtn2.Lines = new string[0];
            this.txtn2.Location = new System.Drawing.Point(61, 191);
            this.txtn2.MaxLength = 32767;
            this.txtn2.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtn2.Modified = false;
            this.txtn2.Multiline = false;
            this.txtn2.Name = "txtn2";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtn2.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtn2.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtn2.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtn2.OnIdleState = stateProperties4;
            this.txtn2.Padding = new System.Windows.Forms.Padding(3);
            this.txtn2.PasswordChar = '\0';
            this.txtn2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtn2.PlaceholderText = "Digite o segundo valor...";
            this.txtn2.ReadOnly = false;
            this.txtn2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtn2.SelectedText = "";
            this.txtn2.SelectionLength = 0;
            this.txtn2.SelectionStart = 0;
            this.txtn2.ShortcutsEnabled = true;
            this.txtn2.Size = new System.Drawing.Size(260, 36);
            this.txtn2.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtn2.TabIndex = 5;
            this.txtn2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtn2.TextMarginBottom = 0;
            this.txtn2.TextMarginLeft = 3;
            this.txtn2.TextMarginTop = 0;
            this.txtn2.TextPlaceholder = "Digite o segundo valor...";
            this.txtn2.UseSystemPasswordChar = false;
            this.txtn2.WordWrap = true;
            // 
            // txtresultado
            // 
            this.txtresultado.AcceptsReturn = false;
            this.txtresultado.AcceptsTab = false;
            this.txtresultado.AnimationSpeed = 200;
            this.txtresultado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtresultado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtresultado.BackColor = System.Drawing.Color.Transparent;
            this.txtresultado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtresultado.BackgroundImage")));
            this.txtresultado.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtresultado.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtresultado.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtresultado.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtresultado.BorderRadius = 15;
            this.txtresultado.BorderThickness = 1;
            this.txtresultado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtresultado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtresultado.DefaultFont = new System.Drawing.Font("SF UI Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresultado.DefaultText = "";
            this.txtresultado.Enabled = false;
            this.txtresultado.FillColor = System.Drawing.Color.White;
            this.txtresultado.HideSelection = true;
            this.txtresultado.IconLeft = null;
            this.txtresultado.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtresultado.IconPadding = 10;
            this.txtresultado.IconRight = null;
            this.txtresultado.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtresultado.Lines = new string[0];
            this.txtresultado.Location = new System.Drawing.Point(61, 318);
            this.txtresultado.MaxLength = 32767;
            this.txtresultado.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtresultado.Modified = false;
            this.txtresultado.Multiline = false;
            this.txtresultado.Name = "txtresultado";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtresultado.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtresultado.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtresultado.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtresultado.OnIdleState = stateProperties8;
            this.txtresultado.Padding = new System.Windows.Forms.Padding(3);
            this.txtresultado.PasswordChar = '\0';
            this.txtresultado.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtresultado.PlaceholderText = "Seu resultado é...";
            this.txtresultado.ReadOnly = false;
            this.txtresultado.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtresultado.SelectedText = "";
            this.txtresultado.SelectionLength = 0;
            this.txtresultado.SelectionStart = 0;
            this.txtresultado.ShortcutsEnabled = true;
            this.txtresultado.Size = new System.Drawing.Size(260, 36);
            this.txtresultado.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtresultado.TabIndex = 6;
            this.txtresultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtresultado.TextMarginBottom = 0;
            this.txtresultado.TextMarginLeft = 3;
            this.txtresultado.TextMarginTop = 0;
            this.txtresultado.TextPlaceholder = "Seu resultado é...";
            this.txtresultado.UseSystemPasswordChar = false;
            this.txtresultado.WordWrap = true;
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(57, 293);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(142, 22);
            this.lblresultado.TabIndex = 7;
            this.lblresultado.Text = "Seu resultado é:";
            // 
            // txtn1
            // 
            this.txtn1.AcceptsReturn = false;
            this.txtn1.AcceptsTab = false;
            this.txtn1.AnimationSpeed = 200;
            this.txtn1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtn1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtn1.BackColor = System.Drawing.Color.Transparent;
            this.txtn1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtn1.BackgroundImage")));
            this.txtn1.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtn1.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtn1.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtn1.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtn1.BorderRadius = 15;
            this.txtn1.BorderThickness = 1;
            this.txtn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtn1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtn1.DefaultFont = new System.Drawing.Font("SF UI Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtn1.DefaultText = "";
            this.txtn1.FillColor = System.Drawing.Color.White;
            this.txtn1.HideSelection = true;
            this.txtn1.IconLeft = null;
            this.txtn1.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtn1.IconPadding = 10;
            this.txtn1.IconRight = null;
            this.txtn1.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtn1.Lines = new string[0];
            this.txtn1.Location = new System.Drawing.Point(61, 108);
            this.txtn1.MaxLength = 32767;
            this.txtn1.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtn1.Modified = false;
            this.txtn1.Multiline = false;
            this.txtn1.Name = "txtn1";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtn1.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtn1.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtn1.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtn1.OnIdleState = stateProperties12;
            this.txtn1.Padding = new System.Windows.Forms.Padding(3);
            this.txtn1.PasswordChar = '\0';
            this.txtn1.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtn1.PlaceholderText = "Digite o primeiro valor...";
            this.txtn1.ReadOnly = false;
            this.txtn1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtn1.SelectedText = "";
            this.txtn1.SelectionLength = 0;
            this.txtn1.SelectionStart = 0;
            this.txtn1.ShortcutsEnabled = true;
            this.txtn1.Size = new System.Drawing.Size(260, 36);
            this.txtn1.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtn1.TabIndex = 8;
            this.txtn1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtn1.TextMarginBottom = 0;
            this.txtn1.TextMarginLeft = 3;
            this.txtn1.TextMarginTop = 0;
            this.txtn1.TextPlaceholder = "Digite o primeiro valor...";
            this.txtn1.UseSystemPasswordChar = false;
            this.txtn1.WordWrap = true;
            // 
            // frmSubtracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 450);
            this.Controls.Add(this.txtn1);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.txtn2);
            this.Controls.Add(this.grpbuttons);
            this.Controls.Add(this.lbln2);
            this.Controls.Add(this.lbln1);
            this.Controls.Add(this.lblsub);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSubtracao";
            this.Text = "Forms Subtração";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpbuttons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsub;
        private System.Windows.Forms.Label lbln1;
        private System.Windows.Forms.Label lbln2;
        private System.Windows.Forms.GroupBox grpbuttons;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSair;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnLimpar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCalcular;
        private Bunifu.UI.WinForms.BunifuTextBox txtn2;
        private Bunifu.UI.WinForms.BunifuTextBox txtresultado;
        private System.Windows.Forms.Label lblresultado;
        private Bunifu.UI.WinForms.BunifuTextBox txtn1;
    }
}

