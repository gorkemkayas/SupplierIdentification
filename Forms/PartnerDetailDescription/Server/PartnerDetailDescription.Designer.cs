using System;
using System.Collections.Generic;
using Bimser.Synergy.Entities.DataSource;
using Bimser.Synergy.Entities.DataSource.Providers;
using Bimser.CSP.FormControls.Base;
using Bimser.CSP.FormControls.Common;
using Bimser.CSP.FormControls.Controls;
using Bimser.CSP.FormControls.RuleManager;
using Bimser.CSP.FormControls.Enums;
using Bimser.Framework.Entities;
using Bimser.Framework.Monitoring;
using Newtonsoft.Json;
using SupplierIdentification.Entities;

namespace SupplierIdentification.Forms {

    public partial class PartnerDetailDescription : Form<E_SupplierIdentification_PartnerDetailDescriptionEntity> {

        // properties
        ComboBox Csp { get; set; }
TextBox PartnerCompanyName { get; set; }
Column Column6 { get; set; }
Column Column7 { get; set; }
Column Column8 { get; set; }
TextBox Street { get; set; }
MaskInput AccountantNumber { get; set; }
Column Column9 { get; set; }
Header Header1 { get; set; }
ComboBox eBA { get; set; }
Section Section10 { get; set; }
Header Header2 { get; set; }
Section Section11 { get; set; }
MaskInput FaxNumber { get; set; }
Button imageAdd { get; set; }
Button imageDelete { get; set; }
Section Section12 { get; set; }
ComboBox Synergy { get; set; }
Tab Tab_1 { get; set; }
MaskInput FirmNumber { get; set; }
Section Section13 { get; set; }
TextBox PartnerWebAddress { get; set; }
Tab Tab_2 { get; set; }
ComboBox Ensemble { get; set; }
Tab Tab_3 { get; set; }
Header Galeri { get; set; }
Tab Tab_4 { get; set; }
Tab Tab_5 { get; set; }
Header ContactInformation { get; set; }
Tab Tab_6 { get; set; }
Section Section1 { get; set; }
Tab Tab_7 { get; set; }
Section Section2 { get; set; }
Section Section3 { get; set; }
TextBox District { get; set; }
Section Section4 { get; set; }
ComboBox bEAM { get; set; }
Section Section5 { get; set; }
TextBox Province { get; set; }
NumberBox WorkerCount { get; set; }
Section Section6 { get; set; }
Header AccountantInformation { get; set; }
Section Section7 { get; set; }
Image PartnerImage { get; set; }
Section Section8 { get; set; }
ComboBox Services1 { get; set; }
Column Column20 { get; set; }
Section Section9 { get; set; }
Column Column10 { get; set; }
Column Column21 { get; set; }
MaskInput MaskInput3 { get; set; }
Column Column11 { get; set; }
Image Image1 { get; set; }
TextBox Website1 { get; set; }
NumberBox IMAGEID { get; set; }
Column Column12 { get; set; }
TextBox SocialMedia { get; set; }
Image Image2 { get; set; }
Column Column13 { get; set; }
Divider Divider1 { get; set; }
Image Image3 { get; set; }
ComboBox SectorKnowledge { get; set; }
Column Column14 { get; set; }
TextBox Neighbourhood { get; set; }
ComboBox Qdms { get; set; }
Column Column15 { get; set; }
Divider Divider3 { get; set; }
TextArea AccountantAddress { get; set; }
Column Column16 { get; set; }
Divider Divider4 { get; set; }
Column Column1 { get; set; }
Column Column17 { get; set; }
Divider Divider5 { get; set; }
Column Column2 { get; set; }
HTMLTextBox HTMLDetail { get; set; }
Column Column18 { get; set; }
TextBox AddressNumber { get; set; }
TextArea CoverLetter { get; set; }
Tabs PartnerDetailedTab { get; set; }
Column Column3 { get; set; }
RelatedDocuments imageDocuments { get; set; }
Column Column19 { get; set; }
Column Column4 { get; set; }
Column Column5 { get; set; }


        // constructor
        public PartnerDetailDescription(FormHttpParameters httpParameters, IContext context)
 : base(httpParameters, context)
        {
        }

        // initialize members
        public override void InitMembers()
        {
            
Csp = new ComboBox {
ControlId = "d1af3a96-ab39-a84b-cc62-9d6d30d7b6af",
Name = "Csp",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "CSP Partnerlik Seviyesi" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 150,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "SL.CSP",
ReadOnly = false,
DefaultReadOnly = false,
Required = false,
Indexable = false,
TabIndex = 0,
Value = null,
DataSource = new DataSource {
},
DataSourceType = DataSourceType.Static,
ValueType = PrimitiveType.String,
DateValueFormat = "",
DecimalValuePrecision = 0,
Placeholder = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Partnerlik Seviyesi Belirtiniz..." },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
AllowClear = true,
ShowSearch = false,
SizeType = null,
IconMatchers = new List<IconMatchers>{
},
IconExpr = "",
HideForceRefreshButton = false,
};

Controls.Add(Csp);
Csp.Items = new ListItemCollection();

Csp.Items.Add(new ListItem {
Value = "Gold",
Key = "Gold",
Icon = @"circle-yellow",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "CSP Gold Partnerlik" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

Csp.Items.Add(new ListItem {
Value = "Silver",
Key = "Silver",
Icon = @"circle-grey",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "CSP Silver Partnerlik" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

Csp.Items.Add(new ListItem {
Value = "Bronze",
Key = "Bronze",
Icon = @"circle-orange",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "CSP Bronze Partnerlik" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

Csp.Items.Add(new ListItem {
Value = "NoPartner",
Key = "NoPartner",
Icon = @"reject",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "CSP Partnerliğim Yok" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

BaseComponent default_cspComponent = new BaseComponent {
Id = "Csp",
Type = "ComboBox",
ParentId = "Column8",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = Csp,
ViewProperties = "",
};

AddToViewItems("default", default_cspComponent);

PartnerCompanyName = new TextBox {
ControlId = "0a2cebce-1246-a8de-1a0e-d604a2866755",
Name = "PartnerCompanyName",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "ML.PARTNERCOMPANYNAME",
ReadOnly = false,
DefaultReadOnly = false,
Required = false,
Indexable = false,
TabIndex = 0,
Value = null,
Text = "",
Placeholder = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
MaxLength = 50,
IsSecretData = false,
EnableMultiLanguageText = false,
ShowCharacterCounter = false,
MultiLanguageText = new MultiLanguageText(new Dictionary<string, string> {{ "system", "Mita Yazılım" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
SizeType = null,
};

Controls.Add(PartnerCompanyName);

BaseComponent default_partnercompanynameComponent = new BaseComponent {
Id = "PartnerCompanyName",
Type = "TextBox",
ParentId = "Column3",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = PartnerCompanyName,
ViewProperties = "",
};

AddToViewItems("default", default_partnercompanynameComponent);

Column6 = new Column {
ControlId = "ab852a65-45bd-42bb-b0d5-8d4fa42e0270",
Name = "Column6",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
};


BaseComponent default_column6Component = new BaseComponent {
Id = "Column6",
Type = "Column",
ParentId = "Section3",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = "400",
Visible = true,
ClientVisible = true,
Padding = "0px 10px 0px 10px",
},
},
Items = new List<string> {
"CoverLetter",
"SectorKnowledge",
"Services1",
"WorkerCount",
"HTMLDetail",
},
Properties = Column6,
ViewProperties = "",
};

AddToViewItems("default", default_column6Component);
Controls.Add(Column6);

Column7 = new Column {
ControlId = "984c8516-992e-4135-bce8-eb1111bcbbe4",
Name = "Column7",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
};


BaseComponent default_column7Component = new BaseComponent {
Id = "Column7",
Type = "Column",
ParentId = "Section4",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Header1",
"Divider1",
},
Properties = Column7,
ViewProperties = "",
};

AddToViewItems("default", default_column7Component);
Controls.Add(Column7);

Column8 = new Column {
ControlId = "6e7c561e-afd2-4ca7-b24a-ce996ad5bde9",
Name = "Column8",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
};


BaseComponent default_column8Component = new BaseComponent {
Id = "Column8",
Type = "Column",
ParentId = "Section5",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"bEAM",
"Qdms",
"Csp",
},
Properties = Column8,
ViewProperties = "",
};

AddToViewItems("default", default_column8Component);
Controls.Add(Column8);

Street = new TextBox {
ControlId = "97f48462-c47f-c78f-3733-b8c99ab3f0d3",
Name = "Street",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Cadde Bilgisi" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Center,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = true
},
EntityPath = "ML.STREET",
ReadOnly = false,
DefaultReadOnly = false,
Required = false,
Indexable = false,
TabIndex = 0,
Value = null,
Text = "",
Placeholder = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Cadde Bilgisini Giriniz..." },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
MaxLength = 50,
IsSecretData = false,
EnableMultiLanguageText = false,
ShowCharacterCounter = false,
MultiLanguageText = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
SizeType = null,
};

Controls.Add(Street);

BaseComponent default_streetComponent = new BaseComponent {
Id = "Street",
Type = "TextBox",
ParentId = "Column10",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = Street,
ViewProperties = "",
};

AddToViewItems("default", default_streetComponent);

AccountantNumber = new MaskInput {
ControlId = "249d2413-1a4a-4e72-32dd-1e18ddaa91ea",
Name = "AccountantNumber",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Muhasebe İletişim" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 140,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = true
},
EntityPath = "AccountantNumber",
ReadOnly = false,
DefaultReadOnly = false,
Required = false,
Indexable = false,
TabIndex = 0,
Value = null,
Text = "",
Placeholder = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "İletişim Bilgisi Giriniz..." },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
Mask = @"+\90\ (999) 999 99 99",
FormatChars = new List<TextValueItem> {
},
SizeType = null,
MaxLength = 50,
};

Controls.Add(AccountantNumber);

BaseComponent default_accountantnumberComponent = new BaseComponent {
Id = "AccountantNumber",
Type = "MaskInput",
ParentId = "Column15",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = AccountantNumber,
ViewProperties = "",
};

AddToViewItems("default", default_accountantnumberComponent);

ClientVisible = true;
ProjectName = "SupplierIdentification";
ProjectId = "561223b1-10f4-4f7e-88c7-35378b4dd997";
EntityPath = "";
ActiveView = "default";
Version = 19;
ReadOnly = false;
DefaultReadOnly = false;
Text = new Dictionary<string, string> {
{ "tr-TR", "PartnerDetailDescription" },
{ "en-US", "PartnerDetailDescription" },
{ "ru-RU", "PartnerDetailDescription" },
{ "az-Latn-AZ", "PartnerDetailDescription" },
};
Name = "PartnerDetailDescription";
FormId = "c8e3249b-e5bf-4b11-86d3-99bb78c64e6a";
FormType = FormType.Parameter;
ServerEvents = new List<EventItem> {
};
ClientEvents = new List<EventItem> {
new EventItem {
Name = "OnLoad",
MethodName = "PartnerDetailDescription_OnLoad",
Async = null
},
};
Statuses = new List<DocumentStatus> {
};
IdentityFormat = "<u>";
IdentityFormatId = 0;
PrintingEnabled = false;
PrintView = "default";
CopyPasteEnabled = false;
VersioningEnabled = false;
CanSaveAsDraft = false;
PanelSize = 2;
Style = new Style {
Padding = "10px 20px 10px 20px",
BackgroundColor = "rgba(255, 255, 255, 0)",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
};
PublicFields = new List<FormPublicField> {
};
ToolbarButtons = new List<ToolbarButton> {
new ToolbarButton {
Key = "toolbarSaveButton",
Name = "Kaydet",
Icon = "save",
Enabled = true,
DefaultEnabled = true,
Validate = false,
Caption = new Dictionary<string, string> {
{ "tr-TR", "Kaydet" },
{ "en-US", "Save" },
{ "ru-RU", "Сохранять" },
{ "az-Latn-AZ", "Yadda Saxla" },
},
View = "",
IsServerPrint = false,
},
new ToolbarButton {
Key = "toolbarSaveAsButton",
Name = "Farklı Kaydet",
Icon = "save-as",
Enabled = false,
DefaultEnabled = false,
Validate = false,
Caption = new Dictionary<string, string> {
{ "tr-TR", "Farklı Kaydet" },
{ "en-US", "Save As" },
{ "ru-RU", "Сохранить как" },
{ "az-Latn-AZ", "Fərqli Saxla" },
},
View = "",
IsServerPrint = false,
},
};
Variables = new Dictionary<string, object> {
};
Rules = new Dictionary<string, Rule> {
};
CheckInCheckOut = new CheckInCheckOutOptions {
Enabled = false,
Timeout = 10,
AdditionalTime = 5,
};
SizeType = SizeType.Middle;
PaddingType = SizeType.Middle;
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Düzenle" },{ "en-US", "PartnerDetailDescription" },{ "ru-RU", "PartnerDetailDescription" },{ "az-Latn-AZ", "PartnerDetailDescription" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
};

Controls.Add(this);

BaseComponent default_partnerdetaildescriptionComponent = new BaseComponent {
Id = "PartnerDetailDescription",
Type = "Form",
ParentId = "",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Section1",
"Section2",
},
Properties = this,
ViewProperties = "",
};

AddToViewItems("default", default_partnerdetaildescriptionComponent);

Column9 = new Column {
ControlId = "62f545e7-23e8-43a4-859d-ce239fe5e974",
Name = "Column9",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
};


BaseComponent default_column9Component = new BaseComponent {
Id = "Column9",
Type = "Column",
ParentId = "Section5",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Ensemble",
"eBA",
"Synergy",
},
Properties = Column9,
ViewProperties = "",
};

AddToViewItems("default", default_column9Component);
Controls.Add(Column9);

Header1 = new Header {
ControlId = "37f7135e-b58f-480f-7a07-f7f0aff8d6c0",
Name = "Header1",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Header1" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "16",
Color = "#555",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Bimser Çözüm Partnerlik Seviyeleri" },{ "en-US", "Header1" },{ "ru-RU", "Header1" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
HeadingType = "h3"
};

Controls.Add(Header1);

BaseComponent default_header1Component = new BaseComponent {
Id = "Header1",
Type = "Header",
ParentId = "Column7",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = Header1,
ViewProperties = "",
};

AddToViewItems("default", default_header1Component);

eBA = new ComboBox {
ControlId = "770892bd-0abc-102d-5e63-5e471dcc2892",
Name = "eBA",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "eBA Partnerlik Seviyesi" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 156,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "SL.EBA",
ReadOnly = false,
DefaultReadOnly = false,
Required = false,
Indexable = false,
TabIndex = 0,
Value = null,
DataSource = new DataSource {
},
DataSourceType = DataSourceType.Static,
ValueType = PrimitiveType.String,
DateValueFormat = "",
DecimalValuePrecision = 0,
Placeholder = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Partnerlik Seviyesi Belirtiniz..." },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
AllowClear = true,
ShowSearch = false,
SizeType = null,
IconMatchers = new List<IconMatchers>{
},
IconExpr = "",
HideForceRefreshButton = false,
};

Controls.Add(eBA);
eBA.Items = new ListItemCollection();

eBA.Items.Add(new ListItem {
Value = "Gold",
Key = "Gold",
Icon = @"circle-yellow",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "eBA Gold Partnerlik" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

eBA.Items.Add(new ListItem {
Value = "Silver",
Key = "Silver",
Icon = @"circle-grey",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "eBA Silver Partnerlik" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

eBA.Items.Add(new ListItem {
Value = "Bronze",
Key = "Bronze",
Icon = @"circle-orange",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "eBA Bronze Partnerlik" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

eBA.Items.Add(new ListItem {
Value = "NoPartner",
Key = "NoPartner",
Icon = @"reject",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "eBA Partnerliğim Yok" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

BaseComponent default_ebaComponent = new BaseComponent {
Id = "eBA",
Type = "ComboBox",
ParentId = "Column9",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = eBA,
ViewProperties = "",
};

AddToViewItems("default", default_ebaComponent);

Section10 = new Section {
ControlId = "7d29c5ce-6ade-49ae-8c3e-6260d012eb0d",
Name = "Section10",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
};


BaseComponent default_section10Component = new BaseComponent {
Id = "Section10",
Type = "Section",
ParentId = "Tab_6",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column16",
},
Properties = Section10,
ViewProperties = "",
};

AddToViewItems("default", default_section10Component);
Controls.Add(Section10);

Header2 = new Header {
ControlId = "7d7436dd-51f9-ac3b-fd60-fba3df0524e7",
Name = "Header2",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Header2" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "16",
Color = "#555",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Adres Bilgileri" },{ "en-US", "Header2" },{ "ru-RU", "Header2" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
HeadingType = "h3"
};

Controls.Add(Header2);

BaseComponent default_header2Component = new BaseComponent {
Id = "Header2",
Type = "Header",
ParentId = "Column10",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = Header2,
ViewProperties = "",
};

AddToViewItems("default", default_header2Component);

Section11 = new Section {
ControlId = "8d78d096-f4be-4631-b8ec-0c5b0518bf05",
Name = "Section11",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
};


BaseComponent default_section11Component = new BaseComponent {
Id = "Section11",
Type = "Section",
ParentId = "Tab_6",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column17",
"Column18",
"Column19",
},
Properties = Section11,
ViewProperties = "",
};

AddToViewItems("default", default_section11Component);
Controls.Add(Section11);

FaxNumber = new MaskInput {
ControlId = "581c5401-5048-6844-8a20-5704c6754638",
Name = "FaxNumber",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Fax Numarası" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Center,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "FAXNUMBER",
ReadOnly = false,
DefaultReadOnly = false,
Required = false,
Indexable = false,
TabIndex = 0,
Value = null,
Text = "",
Placeholder = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
Mask = @"+\90\ (999) 999 99 99",
FormatChars = new List<TextValueItem> {
},
SizeType = null,
MaxLength = 50,
};

Controls.Add(FaxNumber);

BaseComponent default_faxnumberComponent = new BaseComponent {
Id = "FaxNumber",
Type = "MaskInput",
ParentId = "Column13",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = FaxNumber,
ViewProperties = "",
};

AddToViewItems("default", default_faxnumberComponent);

imageAdd = new Button {
ControlId = "05d53f21-de55-5d45-2901-0fe53457a186",
Name = "imageAdd",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
new EventItem {
Name = "OnClick",
MethodName = "imageAdd_OnClick",
Async = null
},
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "imageAdd" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Ekle" },{ "en-US", "Button1" },{ "ru-RU", "Button1" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
SizeType = null,
ButtonType = ButtonType.Default,
Icon = "add",
Danger = false,
TabIndex = 0,
Ghost = false,
Block = false,
};

Controls.Add(imageAdd);

BaseComponent default_imageaddComponent = new BaseComponent {
Id = "imageAdd",
Type = "Button",
ParentId = "Column1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = imageAdd,
ViewProperties = "",
};

AddToViewItems("default", default_imageaddComponent);

imageDelete = new Button {
ControlId = "4a209ee8-d92d-d2bd-6e06-dffa244def26",
Name = "imageDelete",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
new EventItem {
Name = "OnClick",
MethodName = "imageDelete_OnClick",
Async = null
},
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "imageDelete" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Sil" },{ "en-US", "Button1" },{ "ru-RU", "Button1" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
SizeType = null,
ButtonType = ButtonType.Default,
Icon = "delete",
Danger = false,
TabIndex = 0,
Ghost = false,
Block = false,
};

Controls.Add(imageDelete);

BaseComponent default_imagedeleteComponent = new BaseComponent {
Id = "imageDelete",
Type = "Button",
ParentId = "Column1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = imageDelete,
ViewProperties = "",
};

AddToViewItems("default", default_imagedeleteComponent);

Section12 = new Section {
ControlId = "2df25e96-856b-407a-99b1-a15f90803c72",
Name = "Section12",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
};


BaseComponent default_section12Component = new BaseComponent {
Id = "Section12",
Type = "Section",
ParentId = "Tab_7",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column20",
},
Properties = Section12,
ViewProperties = "",
};

AddToViewItems("default", default_section12Component);
Controls.Add(Section12);

Synergy = new ComboBox {
ControlId = "a5e7fdcc-b008-4810-2bc0-5c7cc17150b5",
Name = "Synergy",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Synergy Partnerlik seviyesi" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 156,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "SL.SYNERGY",
ReadOnly = false,
DefaultReadOnly = false,
Required = false,
Indexable = false,
TabIndex = 0,
Value = null,
DataSource = new DataSource {
},
DataSourceType = DataSourceType.Static,
ValueType = PrimitiveType.String,
DateValueFormat = "",
DecimalValuePrecision = 0,
Placeholder = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Partnerlik Seviyesi Belirtiniz..." },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
AllowClear = true,
ShowSearch = false,
SizeType = null,
IconMatchers = new List<IconMatchers>{
},
IconExpr = "",
HideForceRefreshButton = false,
};

Controls.Add(Synergy);
Synergy.Items = new ListItemCollection();

Synergy.Items.Add(new ListItem {
Value = "Gold",
Key = "Gold",
Icon = @"circle-yellow",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Synergy Gold Partnerlik" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

Synergy.Items.Add(new ListItem {
Value = "Silver",
Key = "Silver",
Icon = @"circle-grey",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Synergy Silver Partnerlik" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

Synergy.Items.Add(new ListItem {
Value = "Bronze",
Key = "Bronze",
Icon = @"circle-orange",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Synergy Bronze Partnerlik" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

Synergy.Items.Add(new ListItem {
Value = "NoPartner",
Key = "NoPartner",
Icon = @"reject",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Synergy Partnerliğim Yok" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

BaseComponent default_synergyComponent = new BaseComponent {
Id = "Synergy",
Type = "ComboBox",
ParentId = "Column9",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = Synergy,
ViewProperties = "",
};

AddToViewItems("default", default_synergyComponent);

Tab_1 = new Tab {
ControlId = "2a53102e-a185-8bef-6a39-c9c3c4c6a61e",
Name = "Tab_1",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "10px 15px 10px 15px",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Genel" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
ReadOnly = false,
DefaultReadOnly = false,
HeaderMode = HeaderMode.Titled,
CollapsedDefault = false,
TitleFont = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "12",
Color = "",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Key = "",
Selected = true,
Icon = "empty-icon",
OrderNo = 0
};

Controls.Add(Tab_1);

BaseComponent default_tab_1Component = new BaseComponent {
Id = "Tab_1",
Type = "Tab",
ParentId = "PartnerDetailedTab",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Section3",
"Section4",
"Section5",
"Section13",
},
Properties = Tab_1,
ViewProperties = "",
};

AddToViewItems("default", default_tab_1Component);

FirmNumber = new MaskInput {
ControlId = "fd6ae85f-aa63-6928-153c-ac8441a637fd",
Name = "FirmNumber",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Genel Sekreter" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "FIRMNUMBER",
ReadOnly = false,
DefaultReadOnly = false,
Required = false,
Indexable = false,
TabIndex = 0,
Value = null,
Text = "",
Placeholder = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
Mask = @"+\90\ (999) 999 99 99",
FormatChars = new List<TextValueItem> {
},
SizeType = null,
MaxLength = 50,
};

Controls.Add(FirmNumber);

BaseComponent default_firmnumberComponent = new BaseComponent {
Id = "FirmNumber",
Type = "MaskInput",
ParentId = "Column12",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = FirmNumber,
ViewProperties = "",
};

AddToViewItems("default", default_firmnumberComponent);

Section13 = new Section {
ControlId = "51377aed-3997-42ee-b95e-a61d7901fa78",
Name = "Section13",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
};


BaseComponent default_section13Component = new BaseComponent {
Id = "Section13",
Type = "Section",
ParentId = "Tab_1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column21",
},
Properties = Section13,
ViewProperties = "",
};

AddToViewItems("default", default_section13Component);
Controls.Add(Section13);

PartnerWebAddress = new TextBox {
ControlId = "a7426a3f-1af2-703e-73d7-859c5e7e446e",
Name = "PartnerWebAddress",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "TextBox2" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "ML.PARTNERWEBADDRESS",
ReadOnly = false,
DefaultReadOnly = false,
Required = false,
Indexable = false,
TabIndex = 0,
Value = null,
Text = "",
Placeholder = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
MaxLength = 50,
IsSecretData = false,
EnableMultiLanguageText = false,
ShowCharacterCounter = false,
MultiLanguageText = new MultiLanguageText(new Dictionary<string, string> {{ "system", "https://mitayazilim.com/" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
SizeType = null,
};

Controls.Add(PartnerWebAddress);

BaseComponent default_partnerwebaddressComponent = new BaseComponent {
Id = "PartnerWebAddress",
Type = "TextBox",
ParentId = "Column3",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = PartnerWebAddress,
ViewProperties = "",
};

AddToViewItems("default", default_partnerwebaddressComponent);

Tab_2 = new Tab {
ControlId = "edb5de86-6a8b-f687-f76c-88e099187209",
Name = "Tab_2",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = false,
DefaultEnabled = false,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "10px 15px 10px 15px",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Değerlendirmeler" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
ReadOnly = false,
DefaultReadOnly = false,
HeaderMode = HeaderMode.Titled,
CollapsedDefault = false,
TitleFont = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "12",
Color = "",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Key = "",
Selected = false,
Icon = "empty-icon",
OrderNo = 1
};

Controls.Add(Tab_2);

BaseComponent default_tab_2Component = new BaseComponent {
Id = "Tab_2",
Type = "Tab",
ParentId = "PartnerDetailedTab",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = Tab_2,
ViewProperties = "",
};

AddToViewItems("default", default_tab_2Component);

Ensemble = new ComboBox {
ControlId = "b28c849c-9342-8e22-42b4-78c66b3acd75",
Name = "Ensemble",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Ensemble Partnerlik Seviyesi" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 156,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "SL.ENSEMBLE",
ReadOnly = false,
DefaultReadOnly = false,
Required = false,
Indexable = false,
TabIndex = 0,
Value = null,
DataSource = new DataSource {
},
DataSourceType = DataSourceType.Static,
ValueType = PrimitiveType.String,
DateValueFormat = "",
DecimalValuePrecision = 0,
Placeholder = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Partnerlik Seviyesi Belirtiniz..." },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
AllowClear = true,
ShowSearch = false,
SizeType = null,
IconMatchers = new List<IconMatchers>{
},
IconExpr = "",
HideForceRefreshButton = false,
};

Controls.Add(Ensemble);
Ensemble.Items = new ListItemCollection();

Ensemble.Items.Add(new ListItem {
Value = "Gold",
Key = "Gold",
Icon = @"circle-yellow",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Ensemble Gold Partnerlik" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

Ensemble.Items.Add(new ListItem {
Value = "Silver",
Key = "Silver",
Icon = @"circle-grey",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Ensemble Silver Partnerlik" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

Ensemble.Items.Add(new ListItem {
Value = "Bronze",
Key = "Bronze",
Icon = @"circle-orange",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Ensemble Bronze Partnerlik" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

Ensemble.Items.Add(new ListItem {
Value = "NoPartner",
Key = "NoPartner",
Icon = @"reject",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Ensembe Partnerliğim Yok" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

BaseComponent default_ensembleComponent = new BaseComponent {
Id = "Ensemble",
Type = "ComboBox",
ParentId = "Column9",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = Ensemble,
ViewProperties = "",
};

AddToViewItems("default", default_ensembleComponent);

Tab_3 = new Tab {
ControlId = "f97ddf2e-5552-3c6a-daa4-50ed09b9370c",
Name = "Tab_3",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "10px 15px 10px 15px",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Adres" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
ReadOnly = false,
DefaultReadOnly = false,
HeaderMode = HeaderMode.Titled,
CollapsedDefault = false,
TitleFont = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "12",
Color = "",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Key = "",
Selected = false,
Icon = "empty-icon",
OrderNo = 2
};

Controls.Add(Tab_3);

BaseComponent default_tab_3Component = new BaseComponent {
Id = "Tab_3",
Type = "Tab",
ParentId = "PartnerDetailedTab",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Section6",
},
Properties = Tab_3,
ViewProperties = "",
};

AddToViewItems("default", default_tab_3Component);

Galeri = new Header {
ControlId = "78f3cf00-d8f4-43a6-7c6a-99b8d01deee9",
Name = "Galeri",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Header3" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "16",
Color = "#555",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Galeri Sayfası" },{ "en-US", "Header3" },{ "ru-RU", "Header3" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
HeadingType = "h3"
};

Controls.Add(Galeri);

BaseComponent default_galeriComponent = new BaseComponent {
Id = "Galeri",
Type = "Header",
ParentId = "Column16",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = Galeri,
ViewProperties = "",
};

AddToViewItems("default", default_galeriComponent);

Tab_4 = new Tab {
ControlId = "cfaaca39-91c5-5caf-81ea-f5bf74f1b8c9",
Name = "Tab_4",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "10px 15px 10px 15px",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "İletişim Bilgileri" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
ReadOnly = false,
DefaultReadOnly = false,
HeaderMode = HeaderMode.Titled,
CollapsedDefault = false,
TitleFont = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "12",
Color = "",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Key = "",
Selected = false,
Icon = "empty-icon",
OrderNo = 3
};

Controls.Add(Tab_4);

BaseComponent default_tab_4Component = new BaseComponent {
Id = "Tab_4",
Type = "Tab",
ParentId = "PartnerDetailedTab",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Section7",
"Section8",
},
Properties = Tab_4,
ViewProperties = "",
};

AddToViewItems("default", default_tab_4Component);

Tab_5 = new Tab {
ControlId = "a2c4acaf-64f7-7d65-92e6-f6a9c82a907c",
Name = "Tab_5",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "10px 15px 10px 15px",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Muhasebe Bilgileri" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
ReadOnly = false,
DefaultReadOnly = false,
HeaderMode = HeaderMode.Titled,
CollapsedDefault = false,
TitleFont = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "12",
Color = "",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Key = "",
Selected = false,
Icon = "empty-icon",
OrderNo = 4
};

Controls.Add(Tab_5);

BaseComponent default_tab_5Component = new BaseComponent {
Id = "Tab_5",
Type = "Tab",
ParentId = "PartnerDetailedTab",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Section9",
},
Properties = Tab_5,
ViewProperties = "",
};

AddToViewItems("default", default_tab_5Component);

ContactInformation = new Header {
ControlId = "0bf56b33-c319-7dcc-df46-742f97e1e717",
Name = "ContactInformation",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "İletişim Bilgileri" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "16",
Color = "#555",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "İletişim Bilgileri" },{ "en-US", "Header3" },{ "ru-RU", "Header3" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
HeadingType = "h3"
};

Controls.Add(ContactInformation);

BaseComponent default_contactinformationComponent = new BaseComponent {
Id = "ContactInformation",
Type = "Header",
ParentId = "Column11",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = ContactInformation,
ViewProperties = "",
};

AddToViewItems("default", default_contactinformationComponent);

Tab_6 = new Tab {
ControlId = "dc215d0d-058e-ca23-7845-47434b69cc6d",
Name = "Tab_6",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "10px 15px 10px 15px",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Galeri" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
ReadOnly = false,
DefaultReadOnly = false,
HeaderMode = HeaderMode.Titled,
CollapsedDefault = false,
TitleFont = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "12",
Color = "",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Key = "",
Selected = false,
Icon = "empty-icon",
OrderNo = 5
};

Controls.Add(Tab_6);

BaseComponent default_tab_6Component = new BaseComponent {
Id = "Tab_6",
Type = "Tab",
ParentId = "PartnerDetailedTab",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Section10",
"Section11",
},
Properties = Tab_6,
ViewProperties = "",
};

AddToViewItems("default", default_tab_6Component);

Section1 = new Section {
ControlId = "836b6cb3-1928-4aca-9ec6-43c26f45885f",
Name = "Section1",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
};


BaseComponent default_section1Component = new BaseComponent {
Id = "Section1",
Type = "Section",
ParentId = "PartnerDetailDescription",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column4",
"Column1",
"Column2",
"Column3",
},
Properties = Section1,
ViewProperties = "",
};

AddToViewItems("default", default_section1Component);
Controls.Add(Section1);

Tab_7 = new Tab {
ControlId = "464982ea-3cca-d663-1ec9-4cc82bbfb213",
Name = "Tab_7",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "10px 15px 10px 15px",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Sosyal Medya" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
ReadOnly = false,
DefaultReadOnly = false,
HeaderMode = HeaderMode.Titled,
CollapsedDefault = false,
TitleFont = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "12",
Color = "",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Key = "",
Selected = false,
Icon = "empty-icon",
OrderNo = 6
};

Controls.Add(Tab_7);

BaseComponent default_tab_7Component = new BaseComponent {
Id = "Tab_7",
Type = "Tab",
ParentId = "PartnerDetailedTab",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Section12",
},
Properties = Tab_7,
ViewProperties = "",
};

AddToViewItems("default", default_tab_7Component);

Section2 = new Section {
ControlId = "b533916c-9385-41a9-82b4-b28eb94c3c72",
Name = "Section2",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
};


BaseComponent default_section2Component = new BaseComponent {
Id = "Section2",
Type = "Section",
ParentId = "PartnerDetailDescription",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column5",
},
Properties = Section2,
ViewProperties = "",
};

AddToViewItems("default", default_section2Component);
Controls.Add(Section2);

Section3 = new Section {
ControlId = "51645938-5c01-4537-a177-037f2a71fe4c",
Name = "Section3",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
};


BaseComponent default_section3Component = new BaseComponent {
Id = "Section3",
Type = "Section",
ParentId = "Tab_1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column6",
},
Properties = Section3,
ViewProperties = "",
};

AddToViewItems("default", default_section3Component);
Controls.Add(Section3);

District = new TextBox {
ControlId = "4887ed9c-c491-8613-7d81-25e3a6da943f",
Name = "District",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "İlçe Bilgisi" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Center,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = true
},
EntityPath = "ML.DISTRICT",
ReadOnly = false,
DefaultReadOnly = false,
Required = false,
Indexable = false,
TabIndex = 0,
Value = null,
Text = "",
Placeholder = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "İlçe Bilgisini Giriniz..." },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
MaxLength = 50,
IsSecretData = false,
EnableMultiLanguageText = false,
ShowCharacterCounter = false,
MultiLanguageText = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
SizeType = null,
};

Controls.Add(District);

BaseComponent default_districtComponent = new BaseComponent {
Id = "District",
Type = "TextBox",
ParentId = "Column10",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = District,
ViewProperties = "",
};

AddToViewItems("default", default_districtComponent);

Section4 = new Section {
ControlId = "a2c62f36-48a8-46fd-8206-ab4cde145671",
Name = "Section4",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
};


BaseComponent default_section4Component = new BaseComponent {
Id = "Section4",
Type = "Section",
ParentId = "Tab_1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column7",
},
Properties = Section4,
ViewProperties = "",
};

AddToViewItems("default", default_section4Component);
Controls.Add(Section4);

bEAM = new ComboBox {
ControlId = "883b427f-149c-38f8-ee7b-44e55bc07f42",
Name = "bEAM",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "bEAM Partnerlik Seviyesi" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 150,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "SL.BEAM",
ReadOnly = false,
DefaultReadOnly = false,
Required = false,
Indexable = false,
TabIndex = 0,
Value = null,
DataSource = new DataSource {
},
DataSourceType = DataSourceType.Static,
ValueType = PrimitiveType.String,
DateValueFormat = "",
DecimalValuePrecision = 0,
Placeholder = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Partnerlik Seviyesi Belirtiniz..." },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
AllowClear = true,
ShowSearch = false,
SizeType = null,
IconMatchers = new List<IconMatchers>{
},
IconExpr = "",
HideForceRefreshButton = false,
};

Controls.Add(bEAM);
bEAM.Items = new ListItemCollection();

bEAM.Items.Add(new ListItem {
Value = "Gold",
Key = "Gold",
Icon = @"circle-yellow",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "bEAM Gold Partnerlik" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

bEAM.Items.Add(new ListItem {
Value = "Silver",
Key = "Silver",
Icon = @"circle-grey",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "bEAM Silver Partnerlik" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

bEAM.Items.Add(new ListItem {
Value = "Bronze",
Key = "Bronze",
Icon = @"circle-orange",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "bEAM Bronze Partnerlik" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

bEAM.Items.Add(new ListItem {
Value = "NoPartner",
Key = "NoPartner",
Icon = @"reject",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "bEAM Partnerliğim Yok" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

BaseComponent default_beamComponent = new BaseComponent {
Id = "bEAM",
Type = "ComboBox",
ParentId = "Column8",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = bEAM,
ViewProperties = "",
};

AddToViewItems("default", default_beamComponent);

Section5 = new Section {
ControlId = "0f180a8b-4d44-4f14-852b-bc25fe081641",
Name = "Section5",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
};


BaseComponent default_section5Component = new BaseComponent {
Id = "Section5",
Type = "Section",
ParentId = "Tab_1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column8",
"Column9",
},
Properties = Section5,
ViewProperties = "",
};

AddToViewItems("default", default_section5Component);
Controls.Add(Section5);

Province = new TextBox {
ControlId = "29e261bd-3355-00a3-0361-363385e1136b",
Name = "Province",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "İl Bilgisi" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Center,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = true
},
EntityPath = "ML.PROVINCE",
ReadOnly = false,
DefaultReadOnly = false,
Required = false,
Indexable = false,
TabIndex = 0,
Value = null,
Text = "",
Placeholder = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "İl Bilgisini Giriniz..." },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
MaxLength = 50,
IsSecretData = false,
EnableMultiLanguageText = false,
ShowCharacterCounter = false,
MultiLanguageText = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
SizeType = null,
};

Controls.Add(Province);

BaseComponent default_provinceComponent = new BaseComponent {
Id = "Province",
Type = "TextBox",
ParentId = "Column10",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = Province,
ViewProperties = "",
};

AddToViewItems("default", default_provinceComponent);

WorkerCount = new NumberBox {
ControlId = "c717de39-0c38-4bca-3745-23f8617840b4",
Name = "WorkerCount",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Çalışan Sayısı" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Top,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "WORKERCOUNT",
ReadOnly = false,
DefaultReadOnly = false,
Required = false,
Indexable = false,
TabIndex = 0,
Value = null,
Text = "",
Placeholder = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Çalışan Sayısı Belirtiniz..." },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
Min = 0M,
Max = 99999999999999M,
Step = 1M,
Precision = 0,
UseThousandSeparator = false,
OnlyNumber = false,
SizeType = null,
};

Controls.Add(WorkerCount);

BaseComponent default_workercountComponent = new BaseComponent {
Id = "WorkerCount",
Type = "NumberBox",
ParentId = "Column6",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = WorkerCount,
ViewProperties = "",
};

AddToViewItems("default", default_workercountComponent);

Section6 = new Section {
ControlId = "1db9c8fa-3b11-4e00-8316-8d85517ffa5e",
Name = "Section6",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
};


BaseComponent default_section6Component = new BaseComponent {
Id = "Section6",
Type = "Section",
ParentId = "Tab_3",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column10",
},
Properties = Section6,
ViewProperties = "",
};

AddToViewItems("default", default_section6Component);
Controls.Add(Section6);

AccountantInformation = new Header {
ControlId = "cb652143-fa3c-ec95-d646-f7ce5993e0eb",
Name = "AccountantInformation",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Header3" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "16",
Color = "#555",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Muhasebe Bilgileri" },{ "en-US", "Header3" },{ "ru-RU", "Header3" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
HeadingType = "h3"
};

Controls.Add(AccountantInformation);

BaseComponent default_accountantinformationComponent = new BaseComponent {
Id = "AccountantInformation",
Type = "Header",
ParentId = "Column15",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = AccountantInformation,
ViewProperties = "",
};

AddToViewItems("default", default_accountantinformationComponent);

Section7 = new Section {
ControlId = "e1855bb6-caea-4cff-b0eb-49fa09a8c344",
Name = "Section7",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
};


BaseComponent default_section7Component = new BaseComponent {
Id = "Section7",
Type = "Section",
ParentId = "Tab_4",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column11",
},
Properties = Section7,
ViewProperties = "",
};

AddToViewItems("default", default_section7Component);
Controls.Add(Section7);

PartnerImage = new Image {
ControlId = "ba7c228e-c7e1-3bb4-cab4-e36ee82ab9ca",
Name = "PartnerImage",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "PartnerImage" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
SourceType = ImageSourceType.Local,
FileName = "/Sample_User_Icon.png",
Alt = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Size = new Size {
Width = 120,
Height = 120
},
};

Controls.Add(PartnerImage);

BaseComponent default_partnerimageComponent = new BaseComponent {
Id = "PartnerImage",
Type = "Image",
ParentId = "Column1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = PartnerImage,
ViewProperties = "",
};

AddToViewItems("default", default_partnerimageComponent);

Section8 = new Section {
ControlId = "46355a89-c07f-4001-b864-10cd200b9b97",
Name = "Section8",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
};


BaseComponent default_section8Component = new BaseComponent {
Id = "Section8",
Type = "Section",
ParentId = "Tab_4",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column12",
"Column13",
"Column14",
},
Properties = Section8,
ViewProperties = "",
};

AddToViewItems("default", default_section8Component);
Controls.Add(Section8);

Services1 = new ComboBox {
ControlId = "1f26c345-15e9-08a9-514d-9ab72de950d2",
Name = "Services1",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Hizmetler" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Top,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "SL.SERVICES1",
ReadOnly = false,
DefaultReadOnly = false,
Required = false,
Indexable = false,
TabIndex = 0,
Value = null,
DataSource = new DataSource {
},
DataSourceType = DataSourceType.Static,
ValueType = PrimitiveType.String,
DateValueFormat = "",
DecimalValuePrecision = 0,
Placeholder = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Hizmet Seçiniz..." },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
AllowClear = true,
ShowSearch = false,
SizeType = null,
IconMatchers = new List<IconMatchers>{
},
IconExpr = "",
HideForceRefreshButton = false,
};

Controls.Add(Services1);
Services1.Items = new ListItemCollection();

Services1.Items.Add(new ListItem {
Value = "1",
Key = "1",
Icon = @"",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Kamu Hizmetleri" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

Services1.Items.Add(new ListItem {
Value = "2",
Key = "2",
Icon = @"",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Bilgi ve İletişim" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

Services1.Items.Add(new ListItem {
Value = "3",
Key = "3",
Icon = @"",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "İnşaat ve Mühendislik" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

Services1.Items.Add(new ListItem {
Value = "4",
Key = "4",
Icon = @"",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Lojistik" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

Services1.Items.Add(new ListItem {
Value = "5",
Key = "5",
Icon = @"",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Finans" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

Services1.Items.Add(new ListItem {
Value = "6",
Key = "6",
Icon = @"",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Diğer" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

BaseComponent default_services1Component = new BaseComponent {
Id = "Services1",
Type = "ComboBox",
ParentId = "Column6",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = Services1,
ViewProperties = "",
};

AddToViewItems("default", default_services1Component);

Column20 = new Column {
ControlId = "bb94c884-df98-4d76-9fde-2b49ba0ad3d9",
Name = "Column20",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
};


BaseComponent default_column20Component = new BaseComponent {
Id = "Column20",
Type = "Column",
ParentId = "Section12",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Website1",
"SocialMedia",
},
Properties = Column20,
ViewProperties = "",
};

AddToViewItems("default", default_column20Component);
Controls.Add(Column20);

Section9 = new Section {
ControlId = "927e3b85-eb56-4954-8bae-6d81b563bc07",
Name = "Section9",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
};


BaseComponent default_section9Component = new BaseComponent {
Id = "Section9",
Type = "Section",
ParentId = "Tab_5",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column15",
},
Properties = Section9,
ViewProperties = "",
};

AddToViewItems("default", default_section9Component);
Controls.Add(Section9);

Column10 = new Column {
ControlId = "16b28c34-4206-4ca2-81da-bcaf36cd8ba6",
Name = "Column10",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
};


BaseComponent default_column10Component = new BaseComponent {
Id = "Column10",
Type = "Column",
ParentId = "Section6",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Header2",
"Divider3",
"Province",
"District",
"Street",
"Neighbourhood",
"AddressNumber",
},
Properties = Column10,
ViewProperties = "",
};

AddToViewItems("default", default_column10Component);
Controls.Add(Column10);

Column21 = new Column {
ControlId = "4bb7c780-cf65-43cc-8ac4-345b749f933e",
Name = "Column21",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
};


BaseComponent default_column21Component = new BaseComponent {
Id = "Column21",
Type = "Column",
ParentId = "Section13",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"IMAGEID",
"imageDocuments",
},
Properties = Column21,
ViewProperties = "",
};

AddToViewItems("default", default_column21Component);
Controls.Add(Column21);

MaskInput3 = new MaskInput {
ControlId = "ce7b2d04-630d-c6d6-be80-6a2722aa37fe",
Name = "MaskInput3",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Müşteri Hizmetleri" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Center,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "MaskInput3",
ReadOnly = false,
DefaultReadOnly = false,
Required = false,
Indexable = false,
TabIndex = 0,
Value = null,
Text = "",
Placeholder = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
Mask = @"+\90\ (999) 999 99 99",
FormatChars = new List<TextValueItem> {
},
SizeType = null,
MaxLength = 50,
};

Controls.Add(MaskInput3);

BaseComponent default_maskinput3Component = new BaseComponent {
Id = "MaskInput3",
Type = "MaskInput",
ParentId = "Column14",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = MaskInput3,
ViewProperties = "",
};

AddToViewItems("default", default_maskinput3Component);

Column11 = new Column {
ControlId = "2260b855-7b97-4f7b-9f24-05a98537367c",
Name = "Column11",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
};


BaseComponent default_column11Component = new BaseComponent {
Id = "Column11",
Type = "Column",
ParentId = "Section7",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"ContactInformation",
"Divider4",
},
Properties = Column11,
ViewProperties = "",
};

AddToViewItems("default", default_column11Component);
Controls.Add(Column11);

Image1 = new Image {
ControlId = "bb5bee0e-8cfc-1625-ab45-353963b09e88",
Name = "Image1",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Image1" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
SourceType = ImageSourceType.Local,
FileName = "/istockphoto-1413766112-612x612.jpg",
Alt = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Size = new Size {
Width = 500,
Height = 400
},
};

Controls.Add(Image1);

BaseComponent default_image1Component = new BaseComponent {
Id = "Image1",
Type = "Image",
ParentId = "Column17",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = Image1,
ViewProperties = "",
};

AddToViewItems("default", default_image1Component);

Website1 = new TextBox {
ControlId = "3bb3bd4d-b2bd-a047-092d-0700bb55d001",
Name = "Website1",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Firma İnternet Adresi" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = true
},
EntityPath = "ML.WEBSITE1",
ReadOnly = false,
DefaultReadOnly = false,
Required = false,
Indexable = false,
TabIndex = 0,
Value = null,
Text = "",
Placeholder = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Firma İnternet Adres Bilgisini Giriniz..." },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
MaxLength = 100,
IsSecretData = false,
EnableMultiLanguageText = false,
ShowCharacterCounter = false,
MultiLanguageText = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
SizeType = null,
};

Controls.Add(Website1);

BaseComponent default_website1Component = new BaseComponent {
Id = "Website1",
Type = "TextBox",
ParentId = "Column20",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = Website1,
ViewProperties = "",
};

AddToViewItems("default", default_website1Component);

IMAGEID = new NumberBox {
ControlId = "b20a22e3-94fc-6253-d891-edfca2010bdc",
Name = "IMAGEID",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = false,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "IMAGEID" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "IMAGEID",
ReadOnly = false,
DefaultReadOnly = false,
Required = false,
Indexable = false,
TabIndex = 0,
Value = null,
Text = "",
Placeholder = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Right,
Min = null,
Max = 99999999999999M,
Step = 1M,
Precision = 0,
UseThousandSeparator = false,
OnlyNumber = false,
SizeType = null,
};

Controls.Add(IMAGEID);

BaseComponent default_imageidComponent = new BaseComponent {
Id = "IMAGEID",
Type = "NumberBox",
ParentId = "Column21",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = IMAGEID,
ViewProperties = "",
};

AddToViewItems("default", default_imageidComponent);

Column12 = new Column {
ControlId = "79b6e32c-e449-4daa-9b02-351fe5d556fa",
Name = "Column12",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
};


BaseComponent default_column12Component = new BaseComponent {
Id = "Column12",
Type = "Column",
ParentId = "Section8",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"FirmNumber",
},
Properties = Column12,
ViewProperties = "",
};

AddToViewItems("default", default_column12Component);
Controls.Add(Column12);

SocialMedia = new TextBox {
ControlId = "a747329e-8577-223a-2a7c-8a1065e05795",
Name = "SocialMedia",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Sosyal Medya Adresi" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = true
},
EntityPath = "ML.SOCIALMEDIA",
ReadOnly = false,
DefaultReadOnly = false,
Required = false,
Indexable = false,
TabIndex = 0,
Value = null,
Text = "",
Placeholder = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Sosyal Medya Bilgisini Giriniz..." },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
MaxLength = 50,
IsSecretData = false,
EnableMultiLanguageText = false,
ShowCharacterCounter = false,
MultiLanguageText = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
SizeType = null,
};

Controls.Add(SocialMedia);

BaseComponent default_socialmediaComponent = new BaseComponent {
Id = "SocialMedia",
Type = "TextBox",
ParentId = "Column20",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = SocialMedia,
ViewProperties = "",
};

AddToViewItems("default", default_socialmediaComponent);

Image2 = new Image {
ControlId = "8de667bf-f72c-9b68-8528-c1ff176558ca",
Name = "Image2",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Image2" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
SourceType = ImageSourceType.Local,
FileName = "/General-Partnership-Company-Formation-in-Dubai.jpg",
Alt = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Size = new Size {
Width = 500,
Height = 400
},
};

Controls.Add(Image2);

BaseComponent default_image2Component = new BaseComponent {
Id = "Image2",
Type = "Image",
ParentId = "Column18",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = Image2,
ViewProperties = "",
};

AddToViewItems("default", default_image2Component);

Column13 = new Column {
ControlId = "6e4dec60-7d38-4a7c-a75c-56a3f280e6be",
Name = "Column13",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
};


BaseComponent default_column13Component = new BaseComponent {
Id = "Column13",
Type = "Column",
ParentId = "Section8",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"FaxNumber",
},
Properties = Column13,
ViewProperties = "",
};

AddToViewItems("default", default_column13Component);
Controls.Add(Column13);

Divider1 = new Divider {
ControlId = "2b59803a-aacf-c8e5-bd7d-70791d8d9c14",
Name = "Divider1",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Divider1" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
};

Controls.Add(Divider1);

BaseComponent default_divider1Component = new BaseComponent {
Id = "Divider1",
Type = "Divider",
ParentId = "Column7",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = Divider1,
ViewProperties = "",
};

AddToViewItems("default", default_divider1Component);

Image3 = new Image {
ControlId = "540f458c-d1e0-8325-eb1d-24dd0e53ae69",
Name = "Image3",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Image3" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
SourceType = ImageSourceType.Local,
FileName = "/register-company-online-1.png",
Alt = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Size = new Size {
Width = 500,
Height = 400
},
};

Controls.Add(Image3);

BaseComponent default_image3Component = new BaseComponent {
Id = "Image3",
Type = "Image",
ParentId = "Column19",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = Image3,
ViewProperties = "",
};

AddToViewItems("default", default_image3Component);

SectorKnowledge = new ComboBox {
ControlId = "9b738150-c24f-8a3b-ae27-8bee1ff5eae7",
Name = "SectorKnowledge",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Sektör Bilgisi" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Top,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "SL.SECTORKNOWLEDGE",
ReadOnly = false,
DefaultReadOnly = false,
Required = false,
Indexable = false,
TabIndex = 0,
Value = null,
DataSource = new DataSource {
},
DataSourceType = DataSourceType.Static,
ValueType = PrimitiveType.String,
DateValueFormat = "",
DecimalValuePrecision = 0,
Placeholder = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Sektör Bilgi Durumunuzu Seçiniz..." },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
AllowClear = true,
ShowSearch = false,
SizeType = null,
IconMatchers = new List<IconMatchers>{
},
IconExpr = "",
HideForceRefreshButton = false,
};

Controls.Add(SectorKnowledge);
SectorKnowledge.Items = new ListItemCollection();

SectorKnowledge.Items.Add(new ListItem {
Value = "3",
Key = "3",
Icon = @"",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Genel Bilgiye Sahibim" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

SectorKnowledge.Items.Add(new ListItem {
Value = "5",
Key = "5",
Icon = @"",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Oldukça Bilgiliyim" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

SectorKnowledge.Items.Add(new ListItem {
Value = "4",
Key = "4",
Icon = @"",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Bilgiliyim" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

SectorKnowledge.Items.Add(new ListItem {
Value = "2",
Key = "2",
Icon = @"",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Pek Bir Bilgim Yok" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

SectorKnowledge.Items.Add(new ListItem {
Value = "1",
Key = "1",
Icon = @"",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Hiçbir Bilgim Yok" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

BaseComponent default_sectorknowledgeComponent = new BaseComponent {
Id = "SectorKnowledge",
Type = "ComboBox",
ParentId = "Column6",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = SectorKnowledge,
ViewProperties = "",
};

AddToViewItems("default", default_sectorknowledgeComponent);

Column14 = new Column {
ControlId = "a9e0d977-02c2-43cd-83fd-835cc5180975",
Name = "Column14",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
};


BaseComponent default_column14Component = new BaseComponent {
Id = "Column14",
Type = "Column",
ParentId = "Section8",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"MaskInput3",
},
Properties = Column14,
ViewProperties = "",
};

AddToViewItems("default", default_column14Component);
Controls.Add(Column14);

Neighbourhood = new TextBox {
ControlId = "2b4591d1-878e-c74e-d0c8-fef8396740dc",
Name = "Neighbourhood",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Mahalle Bilgisi" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Center,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = true
},
EntityPath = "ML.NEIGHBOURHOOD",
ReadOnly = false,
DefaultReadOnly = false,
Required = false,
Indexable = false,
TabIndex = 0,
Value = null,
Text = "",
Placeholder = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Mahalle Bilgisini Giriniz..." },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
MaxLength = 50,
IsSecretData = false,
EnableMultiLanguageText = false,
ShowCharacterCounter = false,
MultiLanguageText = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
SizeType = null,
};

Controls.Add(Neighbourhood);

BaseComponent default_neighbourhoodComponent = new BaseComponent {
Id = "Neighbourhood",
Type = "TextBox",
ParentId = "Column10",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = Neighbourhood,
ViewProperties = "",
};

AddToViewItems("default", default_neighbourhoodComponent);

Qdms = new ComboBox {
ControlId = "7092fb8a-fbb4-f5a1-c5dd-0a9d5f44eac2",
Name = "Qdms",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "QDMS Partnerlik Seviyesi" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 150,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "SL.QDMS",
ReadOnly = false,
DefaultReadOnly = false,
Required = false,
Indexable = false,
TabIndex = 0,
Value = null,
DataSource = new DataSource {
},
DataSourceType = DataSourceType.Static,
ValueType = PrimitiveType.String,
DateValueFormat = "",
DecimalValuePrecision = 0,
Placeholder = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Partnerlik Seviyesi Belirtiniz..." },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
AllowClear = true,
ShowSearch = false,
SizeType = null,
IconMatchers = new List<IconMatchers>{
},
IconExpr = "",
HideForceRefreshButton = false,
};

Controls.Add(Qdms);
Qdms.Items = new ListItemCollection();

Qdms.Items.Add(new ListItem {
Value = "Gold",
Key = "Gold",
Icon = @"circle-yellow",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "QDMS Gold Partnerlik" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

Qdms.Items.Add(new ListItem {
Value = "Silver",
Key = "Silver",
Icon = @"circle-grey",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "QDMS Silver Partnerlik" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

Qdms.Items.Add(new ListItem {
Value = "Bronze",
Key = "Bronze",
Icon = @"circle-orange",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "QDMS Bronze Partnerlik" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

Qdms.Items.Add(new ListItem {
Value = "NoPartner",
Key = "NoPartner",
Icon = @"reject",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "QDMS Partnerliğim Yok" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

BaseComponent default_qdmsComponent = new BaseComponent {
Id = "Qdms",
Type = "ComboBox",
ParentId = "Column8",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = Qdms,
ViewProperties = "",
};

AddToViewItems("default", default_qdmsComponent);

Column15 = new Column {
ControlId = "85853ac9-5f11-4713-82bb-355a8a5a5d63",
Name = "Column15",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
};


BaseComponent default_column15Component = new BaseComponent {
Id = "Column15",
Type = "Column",
ParentId = "Section9",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"AccountantInformation",
"Divider5",
"AccountantAddress",
"AccountantNumber",
},
Properties = Column15,
ViewProperties = "",
};

AddToViewItems("default", default_column15Component);
Controls.Add(Column15);

Divider3 = new Divider {
ControlId = "b96d3a3a-f06f-1638-9bc1-3ba50134dcd5",
Name = "Divider3",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Divider3" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
};

Controls.Add(Divider3);

BaseComponent default_divider3Component = new BaseComponent {
Id = "Divider3",
Type = "Divider",
ParentId = "Column10",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = Divider3,
ViewProperties = "",
};

AddToViewItems("default", default_divider3Component);

AccountantAddress = new TextArea {
ControlId = "3a282345-e6c2-14d8-3652-07d5df1dd41f",
Name = "AccountantAddress",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Muhasebe Büro Adresi" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 140,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = true
},
EntityPath = "ML.ACCOUNTANTADDRESS",
ReadOnly = false,
DefaultReadOnly = false,
Required = false,
Indexable = false,
TabIndex = 0,
Value = null,
Text = "",
Placeholder = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Muhasebe Büro Adres Bilgisini Giriniz..." },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
MaxLength = 1000,
IsSecretData = false,
EnableMultiLanguageText = false,
ShowCharacterCounter = false,
MultiLanguageText = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Rows = 3
};

Controls.Add(AccountantAddress);

BaseComponent default_accountantaddressComponent = new BaseComponent {
Id = "AccountantAddress",
Type = "TextArea",
ParentId = "Column15",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = AccountantAddress,
ViewProperties = "",
};

AddToViewItems("default", default_accountantaddressComponent);

Column16 = new Column {
ControlId = "519a4418-fc8d-44dd-b383-aa135450ca69",
Name = "Column16",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
};


BaseComponent default_column16Component = new BaseComponent {
Id = "Column16",
Type = "Column",
ParentId = "Section10",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Galeri",
},
Properties = Column16,
ViewProperties = "",
};

AddToViewItems("default", default_column16Component);
Controls.Add(Column16);

Divider4 = new Divider {
ControlId = "66421e07-9c64-0f8c-c30d-c87291c3f99d",
Name = "Divider4",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Divider4" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
};

Controls.Add(Divider4);

BaseComponent default_divider4Component = new BaseComponent {
Id = "Divider4",
Type = "Divider",
ParentId = "Column11",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = Divider4,
ViewProperties = "",
};

AddToViewItems("default", default_divider4Component);

Column1 = new Column {
ControlId = "9fe1d365-390d-4055-b023-e41210480c85",
Name = "Column1",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
};


BaseComponent default_column1Component = new BaseComponent {
Id = "Column1",
Type = "Column",
ParentId = "Section1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = "25%",
Visible = true,
ClientVisible = true,
Padding = "0px 10px 0px 10px",
},
},
Items = new List<string> {
"PartnerImage",
"imageAdd",
"imageDelete",
},
Properties = Column1,
ViewProperties = "",
};

AddToViewItems("default", default_column1Component);
Controls.Add(Column1);

Column17 = new Column {
ControlId = "4f3ee5cd-b863-4bbd-8c0f-c63212695f0d",
Name = "Column17",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
};


BaseComponent default_column17Component = new BaseComponent {
Id = "Column17",
Type = "Column",
ParentId = "Section11",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Image1",
},
Properties = Column17,
ViewProperties = "",
};

AddToViewItems("default", default_column17Component);
Controls.Add(Column17);

Divider5 = new Divider {
ControlId = "7786e55a-acc4-9907-3b67-cfc036309f43",
Name = "Divider5",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Divider5" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
};

Controls.Add(Divider5);

BaseComponent default_divider5Component = new BaseComponent {
Id = "Divider5",
Type = "Divider",
ParentId = "Column15",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = Divider5,
ViewProperties = "",
};

AddToViewItems("default", default_divider5Component);

Column2 = new Column {
ControlId = "542d63b4-4289-4c0c-8651-f61aee898db2",
Name = "Column2",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
};


BaseComponent default_column2Component = new BaseComponent {
Id = "Column2",
Type = "Column",
ParentId = "Section1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = "20%",
Visible = true,
ClientVisible = true,
Padding = "0px 10px 0px 10px",
},
},
Items = new List<string> {
},
Properties = Column2,
ViewProperties = "",
};

AddToViewItems("default", default_column2Component);
Controls.Add(Column2);

HTMLDetail = new HTMLTextBox {
ControlId = "fd571658-4229-fd68-2a51-372ab72947be",
Name = "HTMLDetail",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Detay" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Top,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "ML.HTMLDETAIL",
ReadOnly = false,
DefaultReadOnly = false,
Required = false,
Indexable = false,
TabIndex = 0,
Value = "",
Text = "",
Placeholder = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
MaxLength = 50,
IsSecretData = false,
EnableMultiLanguageText = true,
ShowCharacterCounter = false,
MultiLanguageText = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Height = null,
CharCounterMax = null,
ToolbarBottom = false,
ToolbarType = "basic",
};

Controls.Add(HTMLDetail);

BaseComponent default_htmldetailComponent = new BaseComponent {
Id = "HTMLDetail",
Type = "HTMLTextBox",
ParentId = "Column6",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = HTMLDetail,
ViewProperties = "",
};

AddToViewItems("default", default_htmldetailComponent);

Column18 = new Column {
ControlId = "3fcab364-a7d6-4dd6-933e-1d676a406779",
Name = "Column18",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
};


BaseComponent default_column18Component = new BaseComponent {
Id = "Column18",
Type = "Column",
ParentId = "Section11",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Image2",
},
Properties = Column18,
ViewProperties = "",
};

AddToViewItems("default", default_column18Component);
Controls.Add(Column18);

AddressNumber = new TextBox {
ControlId = "4ab57146-cff0-9778-1f82-3935521ddf04",
Name = "AddressNumber",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Adres Numara Bilgisi" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = true
},
EntityPath = "ML.ADDRESSNUMBER",
ReadOnly = false,
DefaultReadOnly = false,
Required = false,
Indexable = false,
TabIndex = 0,
Value = null,
Text = "",
Placeholder = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Adres Numara Bilgisini Giriniz..." },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
MaxLength = 50,
IsSecretData = false,
EnableMultiLanguageText = false,
ShowCharacterCounter = false,
MultiLanguageText = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
SizeType = null,
};

Controls.Add(AddressNumber);

BaseComponent default_addressnumberComponent = new BaseComponent {
Id = "AddressNumber",
Type = "TextBox",
ParentId = "Column10",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = AddressNumber,
ViewProperties = "",
};

AddToViewItems("default", default_addressnumberComponent);

CoverLetter = new TextArea {
ControlId = "414f51c1-8201-7ba3-7240-3762bd61289a",
Name = "CoverLetter",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Ön Yazı" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Top,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "ML.COVERLETTER",
ReadOnly = false,
DefaultReadOnly = false,
Required = false,
Indexable = false,
TabIndex = 0,
Value = null,
Text = "",
Placeholder = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Hakkınızda Ön Yazı Yazabilirsiniz!" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
MaxLength = 5000,
IsSecretData = false,
EnableMultiLanguageText = true,
ShowCharacterCounter = false,
MultiLanguageText = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Rows = 3
};

Controls.Add(CoverLetter);

BaseComponent default_coverletterComponent = new BaseComponent {
Id = "CoverLetter",
Type = "TextArea",
ParentId = "Column6",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = CoverLetter,
ViewProperties = "",
};

AddToViewItems("default", default_coverletterComponent);

PartnerDetailedTab = new Tabs {
ControlId = "1dfedafc-de01-b5e2-a2bd-2cc237c7ac96",
Name = "PartnerDetailedTab",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = 1250
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "PartnerDetailedTab" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = 400
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
ReadOnly = false,
DefaultReadOnly = false,
Items = new List<TabItem> {
new TabItem {
Title = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Genel" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Key = "Tab_1",
Enabled = true,
Icon = "empty-icon",
OrderNo = 0,
Selected = true
},
new TabItem {
Title = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Değerlendirmeler" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Key = "Tab_2",
Enabled = false,
Icon = "empty-icon",
OrderNo = 1,
Selected = false
},
new TabItem {
Title = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Adres" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Key = "Tab_3",
Enabled = true,
Icon = "empty-icon",
OrderNo = 2,
Selected = false
},
new TabItem {
Title = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "İletişim Bilgileri" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Key = "Tab_4",
Enabled = true,
Icon = "empty-icon",
OrderNo = 3,
Selected = false
},
new TabItem {
Title = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Muhasebe Bilgileri" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Key = "Tab_5",
Enabled = true,
Icon = "empty-icon",
OrderNo = 4,
Selected = false
},
new TabItem {
Title = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Galeri" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Key = "Tab_6",
Enabled = true,
Icon = "empty-icon",
OrderNo = 5,
Selected = false
},
new TabItem {
Title = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Sosyal Medya" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Key = "Tab_7",
Enabled = true,
Icon = "empty-icon",
OrderNo = 6,
Selected = false
},
},
SelectedIndex = 0,
SelectedItem = new TabItem {
Title = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Genel" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Key = "Tab_1",
Enabled = true,
Icon = "empty-icon",
OrderNo = 0,
Selected = true
},
TabPosition = Position.Top,
HasScrollbar = false
};

Controls.Add(PartnerDetailedTab);

BaseComponent default_partnerdetailedtabComponent = new BaseComponent {
Id = "PartnerDetailedTab",
Type = "Tabs",
ParentId = "Column5",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Tab_7",
"Tab_6",
"Tab_5",
"Tab_4",
"Tab_3",
"Tab_2",
"Tab_1",
},
Properties = PartnerDetailedTab,
ViewProperties = "",
};

AddToViewItems("default", default_partnerdetailedtabComponent);

Column3 = new Column {
ControlId = "9a5071fa-b327-4a80-973a-cbef42910ff8",
Name = "Column3",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
};


BaseComponent default_column3Component = new BaseComponent {
Id = "Column3",
Type = "Column",
ParentId = "Section1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = "40%",
Visible = true,
ClientVisible = true,
Padding = "0px 10px 0px 10px",
},
},
Items = new List<string> {
"PartnerCompanyName",
"PartnerWebAddress",
},
Properties = Column3,
ViewProperties = "",
};

AddToViewItems("default", default_column3Component);
Controls.Add(Column3);

imageDocuments = new RelatedDocuments {
ControlId = "42cec880-d26b-4bd6-63b9-5be6db2256d5",
Name = "imageDocuments",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
new EventItem {
Name = "OnAfterFileAdd",
MethodName = "imageDocuments_OnAfterFileAdd",
Async = null
},
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "SupplierIdentification_PartnerDetailDescription_imageDocuments",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "imageDocuments" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Top,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "RD.imageDocuments",
ReadOnly = false,
DefaultReadOnly = false,
Required = false,
Indexable = false,
Categories = new List<RelatedDocumentCategory> {
new RelatedDocumentCategory {
Id = 0,
CategoryId = "07c2877e-0883-11a8-1e0a-d622a4828d64",
Name = new Dictionary<string, string> {
{ "tr-TR", "Varsayılan" },
},
Description = new Dictionary<string, string> {
{ "tr-TR", "Varsayılan" },
},
MinFilesCount = 0,
MaxFilesCount = null,
MaxFileSize = null,
AllowedFileExtensions = new List<string> {
},
Enabled = true,
Path = "",
TargetId = ""
},
},
Files = new List<RelatedDocumentFile> {
},
AddingMode = RelatedDocumentsAddingMode.Local,
ViewType = RelatedDocumentsViewType.Card,
AddNewEnabled = true,
DeleteEnabled = true,
Viewable = true,
CreateEnabled = false,
Path = "GorkemProjects/SupplierIdentification/asset/Görsel Dosyalar",
ShowCategoryDescription = false,
ShowFileDescription = false,
FileDescriptionIsRequired = false,
ShowContentForImageFiles = false,
ShowCreateDate = true,
ShowCreator = false,
ShowFileExtension = true,
ShowPath = true,
EnabledOCR = false,
TargetId = "744623",
AdvancedEdit = false,
};

Controls.Add(imageDocuments);

BaseComponent default_imagedocumentsComponent = new BaseComponent {
Id = "imageDocuments",
Type = "RelatedDocuments",
ParentId = "Column21",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = imageDocuments,
ViewProperties = "",
};

AddToViewItems("default", default_imagedocumentsComponent);

Column19 = new Column {
ControlId = "1eabb562-10af-4488-9e00-451c2f2b45d1",
Name = "Column19",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
};


BaseComponent default_column19Component = new BaseComponent {
Id = "Column19",
Type = "Column",
ParentId = "Section11",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Image3",
},
Properties = Column19,
ViewProperties = "",
};

AddToViewItems("default", default_column19Component);
Controls.Add(Column19);

Column4 = new Column {
ControlId = "5c2de1d2-c129-48f1-a27a-c8822ec14040",
Name = "Column4",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
};


BaseComponent default_column4Component = new BaseComponent {
Id = "Column4",
Type = "Column",
ParentId = "Section1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = "10%",
Visible = true,
ClientVisible = true,
Padding = "0px 10px 0px 10px",
},
},
Items = new List<string> {
},
Properties = Column4,
ViewProperties = "",
};

AddToViewItems("default", default_column4Component);
Controls.Add(Column4);

Column5 = new Column {
ControlId = "c8218748-d114-4b51-8b22-e2ed25094bfe",
Name = "Column5",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
};


BaseComponent default_column5Component = new BaseComponent {
Id = "Column5",
Type = "Column",
ParentId = "Section2",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "0px 10px 0px 10px",
},
},
Items = new List<string> {
"PartnerDetailedTab",
},
Properties = Column5,
ViewProperties = "",
};

AddToViewItems("default", default_column5Component);
Controls.Add(Column5);

        }

        // initialize user events
        public override void InitUserEvents()
        {
            



















































        }
    }
}