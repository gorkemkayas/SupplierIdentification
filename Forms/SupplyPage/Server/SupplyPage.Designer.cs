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

    public partial class SupplyPage : Form<E_SupplierIdentification_SupplyPageEntity> {

        // properties
        Divider Divider9 { get; set; }
Column Column6 { get; set; }
Label Label4 { get; set; }
Column Column7 { get; set; }
Label Label5 { get; set; }
Column Column8 { get; set; }
Switch ACTIVITY2 { get; set; }
Column Column9 { get; set; }
Header Header1 { get; set; }
TextBox CompatibleVersion { get; set; }
Section Section10 { get; set; }
Header Header2 { get; set; }
Section Section11 { get; set; }
Tabs SupplyTab { get; set; }
ComboBox SectorSelection { get; set; }
TextArea SummaryInformation { get; set; }
Header Header3 { get; set; }
Section Section12 { get; set; }
Header Header4 { get; set; }
Section Section13 { get; set; }
Tab Tab_2 { get; set; }
NumberBox HotfixValue { get; set; }
Tab Tab_3 { get; set; }
Tab Tab_4 { get; set; }
Tab Tab_5 { get; set; }
Tab Tab_6 { get; set; }
Section Section1 { get; set; }
Tab Tab_7 { get; set; }
Section Section2 { get; set; }
CheckBox CheckBox1 { get; set; }
Section Section3 { get; set; }
ComboBox CategorySelection { get; set; }
Section Section4 { get; set; }
NumberBox NumberBox1 { get; set; }
Switch Activity { get; set; }
Section Section5 { get; set; }
Section Section6 { get; set; }
Label Label20 { get; set; }
Section Section7 { get; set; }
Label Label21 { get; set; }
Section Section8 { get; set; }
Label Label10 { get; set; }
Label Label22 { get; set; }
DateRangePicker DateRangePicker1 { get; set; }
Section Section9 { get; set; }
ComboBox ComboBox1 { get; set; }
Label Label11 { get; set; }
Label Label23 { get; set; }
Column Column10 { get; set; }
DateRangePicker DateRangePicker2 { get; set; }
Label Label12 { get; set; }
ComboBox SolutionSelect { get; set; }
Label Label24 { get; set; }
Column Column11 { get; set; }
DateRangePicker DateRangePicker3 { get; set; }
FileSelector FileSelector1 { get; set; }
Label Label13 { get; set; }
HTMLTextBox HTMLDetails { get; set; }
Label Label25 { get; set; }
Column Column12 { get; set; }
FileSelector ImageSelector1 { get; set; }
Label Label14 { get; set; }
Label Label26 { get; set; }
Column Column13 { get; set; }
Divider Divider1 { get; set; }
DataGrid Tags1 { get; set; }
NumberBox MajorValue { get; set; }
Label Label15 { get; set; }
Label Label27 { get; set; }
Column Column14 { get; set; }
Divider Divider2 { get; set; }
Signature Signature1 { get; set; }
Label Label16 { get; set; }
Label Label28 { get; set; }
Column Column15 { get; set; }
Divider Divider3 { get; set; }
Signature Signature2 { get; set; }
Label Label17 { get; set; }
Column Column16 { get; set; }
Divider Divider4 { get; set; }
Column Column1 { get; set; }
ComboBox ApplicationName { get; set; }
Label Label18 { get; set; }
Column Column17 { get; set; }
Divider Divider5 { get; set; }
NumberBox MinorValue { get; set; }
Column Column2 { get; set; }
Label Label19 { get; set; }
Column Column18 { get; set; }
Divider Divider6 { get; set; }
Column Column3 { get; set; }
Label Label1 { get; set; }
Divider Divider7 { get; set; }
DataGrid Properties1 { get; set; }
Column Column4 { get; set; }
Label Label2 { get; set; }
Divider Divider8 { get; set; }
Column Column5 { get; set; }
Label Label3 { get; set; }


        // constructor
        public SupplyPage(FormHttpParameters httpParameters, IContext context)
 : base(httpParameters, context)
        {
        }

        // initialize members
        public override void InitMembers()
        {
            
Divider9 = new Divider {
ControlId = "daaf7e0a-8766-d571-6812-ca6b620b971a",
Name = "Divider9",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Divider9" },}){
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

Controls.Add(Divider9);

BaseComponent default_divider9Component = new BaseComponent {
Id = "Divider9",
Type = "Divider",
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
Properties = Divider9,
ViewProperties = "",
};

AddToViewItems("default", default_divider9Component);

Column6 = new Column {
ControlId = "bf29faff-5397-4db5-8ab0-4e8625c23ac6",
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
ParentId = "Section4",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = "33%",
Visible = true,
ClientVisible = true,
Padding = "0px 10px 0px 10px",
},
},
Items = new List<string> {
"MinorValue",
},
Properties = Column6,
ViewProperties = "",
};

AddToViewItems("default", default_column6Component);
Controls.Add(Column6);

Label4 = new Label {
ControlId = "6ce5cc78-7d67-4b5d-c4b6-3faa25769d39",
Name = "Label4",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Label4" },}){
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
Size = "12",
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
Size = "12",
Color = "rgb(0, 0, 0)",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Hizmet Sağlayıcı, Müşteri'ye aşağıda belirtilen yazılımsal çözümler ve hizmetlerden  sağlayacaktır:" },{ "en-US", "Label4" },{ "ru-RU", "Label4" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
};

Controls.Add(Label4);

BaseComponent default_label4Component = new BaseComponent {
Id = "Label4",
Type = "Label",
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
Properties = Label4,
ViewProperties = "",
};

AddToViewItems("default", default_label4Component);

Column7 = new Column {
ControlId = "f34d433d-7ec3-434d-bcfd-1fe2441f1a35",
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
Width = "33%",
Visible = true,
ClientVisible = true,
Padding = "0px 10px 0px 10px",
},
},
Items = new List<string> {
"HotfixValue",
},
Properties = Column7,
ViewProperties = "",
};

AddToViewItems("default", default_column7Component);
Controls.Add(Column7);

Label5 = new Label {
ControlId = "1b852170-7278-3625-cfc8-b94ccd625ee1",
Name = "Label5",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Label5" },}){
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
Size = "12",
Color = "rgb(0, 0, 0)",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Bimser Synergy, eBA, QDMS, Ensemble ve QGRC" },{ "en-US", "Label5" },{ "ru-RU", "Label5" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
};

Controls.Add(Label5);

BaseComponent default_label5Component = new BaseComponent {
Id = "Label5",
Type = "Label",
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
Properties = Label5,
ViewProperties = "",
};

AddToViewItems("default", default_label5Component);

Column8 = new Column {
ControlId = "3bf6b1a8-745e-411e-8865-47f16e103464",
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
"Tags1",
"Activity",
},
Properties = Column8,
ViewProperties = "",
};

AddToViewItems("default", default_column8Component);
Controls.Add(Column8);

ACTIVITY2 = new Switch {
ControlId = "194d19a7-71f3-40f5-f390-3736577d41aa",
Name = "ACTIVITY2",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Aktiflik" },}){
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
EntityPath = "ACTIVITY2",
ReadOnly = false,
DefaultReadOnly = false,
Required = false,
Indexable = false,
TabIndex = 0,
Value = true,
};

Controls.Add(ACTIVITY2);

BaseComponent default_activity2Component = new BaseComponent {
Id = "ACTIVITY2",
Type = "Switch",
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
Properties = ACTIVITY2,
ViewProperties = "",
};

AddToViewItems("default", default_activity2Component);

Column9 = new Column {
ControlId = "9fdfd864-d02a-4026-bdaa-ed9133244317",
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
"Label1",
"Label2",
"Label3",
"Label4",
"Label5",
"Divider7",
"Label10",
"Label11",
"Label12",
"Divider1",
"Label13",
"Label14",
"Label15",
"Divider2",
"Label16",
"Label17",
"Label18",
"DateRangePicker1",
"DateRangePicker2",
"DateRangePicker3",
"Divider3",
"Label19",
"Label20",
"Label21",
"Divider4",
"Label22",
"Label23",
"Divider5",
"Label24",
"Label25",
"Label26",
"Divider6",
},
Properties = Column9,
ViewProperties = "",
};

AddToViewItems("default", default_column9Component);
Controls.Add(Column9);

Header1 = new Header {
ControlId = "14990c86-ebfc-f531-d9d8-b44de44919ac",
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
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Hizmet Sağlayıcı Firma İmzası" },}){
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Hizmet Sağlayıcı Firma İmzası" },{ "en-US", "Header1" },{ "ru-RU", "Header1" },}){
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
Properties = Header1,
ViewProperties = "",
};

AddToViewItems("default", default_header1Component);

CompatibleVersion = new TextBox {
ControlId = "98a57b5f-c3b3-3e44-a0b7-bff73f3d46b8",
Name = "CompatibleVersion",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Uyumlu Versiyon" },}){
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
EntityPath = "ML.COMPATIBLEVERSION",
ReadOnly = false,
DefaultReadOnly = false,
Required = true,
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
MultiLanguageText = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
SizeType = null,
};

Controls.Add(CompatibleVersion);

BaseComponent default_compatibleversionComponent = new BaseComponent {
Id = "CompatibleVersion",
Type = "TextBox",
ParentId = "Column2",
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
Properties = CompatibleVersion,
ViewProperties = "",
};

AddToViewItems("default", default_compatibleversionComponent);

Section10 = new Section {
ControlId = "54441b70-ff39-4f15-9e4f-d6c7c3e94db3",
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
"Column16",
},
Properties = Section10,
ViewProperties = "",
};

AddToViewItems("default", default_section10Component);
Controls.Add(Section10);

Header2 = new Header {
ControlId = "b02676cb-7917-7d4d-1d07-7fa87a30943c",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Hizmet Talep Eden Firma İmzası" },{ "en-US", "Header2" },{ "ru-RU", "Header2" },}){
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
Properties = Header2,
ViewProperties = "",
};

AddToViewItems("default", default_header2Component);

Section11 = new Section {
ControlId = "6088142d-c480-44c2-9d7a-5d4d474b76f2",
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
},
Properties = Section11,
ViewProperties = "",
};

AddToViewItems("default", default_section11Component);
Controls.Add(Section11);

SupplyTab = new Tabs {
ControlId = "9a7ba5a4-1c85-6921-8198-4a0e6403eff2",
Name = "SupplyTab",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Tabs1" },}){
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
Items = new List<TabItem> {
new TabItem {
Title = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Detay Bilgi" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Key = "Tab_6",
Enabled = true,
Icon = "empty-icon",
OrderNo = 0,
Selected = true
},
new TabItem {
Title = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Uygulama Dosyası" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Key = "Tab_7",
Enabled = true,
Icon = "empty-icon",
OrderNo = 1,
Selected = false
},
new TabItem {
Title = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Galeri" },}){
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
Title = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Uygulama Dosyası" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Key = "Tab_2",
Enabled = true,
Icon = "empty-icon",
OrderNo = 3,
Selected = false
},
new TabItem {
Title = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Ücretlendirme" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Key = "Tab_4",
Enabled = true,
Icon = "empty-icon",
OrderNo = 4,
Selected = false
},
new TabItem {
Title = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Şartlar ve Koşullar" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Key = "Tab_5",
Enabled = true,
Icon = "empty-icon",
OrderNo = 5,
Selected = false
},
},
SelectedIndex = 0,
SelectedItem = new TabItem {
Title = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Detay Bilgi" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Key = "Tab_6",
Enabled = true,
Icon = "empty-icon",
OrderNo = 0,
Selected = true
},
TabPosition = Position.Top,
HasScrollbar = true
};

Controls.Add(SupplyTab);

BaseComponent default_supplytabComponent = new BaseComponent {
Id = "SupplyTab",
Type = "Tabs",
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
"Tab_7",
"Tab_6",
"Tab_5",
"Tab_4",
"Tab_3",
},
Properties = SupplyTab,
ViewProperties = "",
};

AddToViewItems("default", default_supplytabComponent);

SectorSelection = new ComboBox {
ControlId = "b46a078f-46be-22f7-f338-1803be566017",
Name = "SectorSelection",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Sektör" },}){
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
Char = "*",
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
EntityPath = "SL.SECTORSELECTION",
ReadOnly = false,
DefaultReadOnly = false,
Required = true,
Indexable = false,
TabIndex = 0,
Value = null,
DataSource = new DataSource {
},
DataSourceType = DataSourceType.Static,
ValueType = PrimitiveType.String,
DateValueFormat = "",
DecimalValuePrecision = 0,
Placeholder = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Sektör Seçiniz..." },}){
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

Controls.Add(SectorSelection);
SectorSelection.Items = new ListItemCollection();

SectorSelection.Items.Add(new ListItem {
Value = "1",
Key = "1",
Icon = @"empty-icon",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Altyapı" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

SectorSelection.Items.Add(new ListItem {
Value = "2",
Key = "2",
Icon = @"empty-icon",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Bilgi & İletişim Teknolojileri" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

SectorSelection.Items.Add(new ListItem {
Value = "3",
Key = "3",
Icon = @"empty-icon",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Enerji" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

SectorSelection.Items.Add(new ListItem {
Value = "4",
Key = "4",
Icon = @"empty-icon",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Finansal Yatırımlar ve Startuplar" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

SectorSelection.Items.Add(new ListItem {
Value = "5",
Key = "5",
Icon = @"empty-icon",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Kimya" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

SectorSelection.Items.Add(new ListItem {
Value = "6",
Key = "6",
Icon = @"empty-icon",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Lojistik ve Ulaştırma" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

SectorSelection.Items.Add(new ListItem {
Value = "7",
Key = "7",
Icon = @"empty-icon",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Makine" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

SectorSelection.Items.Add(new ListItem {
Value = "8",
Key = "8",
Icon = @"empty-icon",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Otomotiv" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

SectorSelection.Items.Add(new ListItem {
Value = "9",
Key = "9",
Icon = @"empty-icon",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Savunma & Havacılık" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

SectorSelection.Items.Add(new ListItem {
Value = "10",
Key = "10",
Icon = @"empty-icon",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Turizm" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

SectorSelection.Items.Add(new ListItem {
Value = "11",
Key = "11",
Icon = @"empty-icon",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Gayrimenkul" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

BaseComponent default_sectorselectionComponent = new BaseComponent {
Id = "SectorSelection",
Type = "ComboBox",
ParentId = "Column2",
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
Properties = SectorSelection,
ViewProperties = "",
};

AddToViewItems("default", default_sectorselectionComponent);

SummaryInformation = new TextArea {
ControlId = "0a05a838-11f0-18c2-e496-59fe8671a2e6",
Name = "SummaryInformation",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Özet Bilgi" },}){
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
VerticalAlign = VerticalAlign.Top,
MarkSettings = new MarkSettings {
Char = "*",
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
EntityPath = "ML.SUMMARYINFORMATION",
ReadOnly = false,
DefaultReadOnly = false,
Required = true,
Indexable = false,
TabIndex = 0,
Value = null,
Text = "",
Placeholder = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Özet Açıklama Giriniz..." },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
MaxLength = 1000,
IsSecretData = false,
EnableMultiLanguageText = true,
ShowCharacterCounter = true,
MultiLanguageText = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Rows = 3
};

Controls.Add(SummaryInformation);

BaseComponent default_summaryinformationComponent = new BaseComponent {
Id = "SummaryInformation",
Type = "TextArea",
ParentId = "Column2",
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
Properties = SummaryInformation,
ViewProperties = "",
};

AddToViewItems("default", default_summaryinformationComponent);

Header3 = new Header {
ControlId = "3a250658-05c2-6dae-71e0-729cb5d32f83",
Name = "Header3",
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
Size = "20",
Color = "#555",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Hizmet Bedelinin Belirlenmesi" },{ "en-US", "Header3" },{ "ru-RU", "Header3" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Center,
HeadingType = "h3"
};

Controls.Add(Header3);

BaseComponent default_header3Component = new BaseComponent {
Id = "Header3",
Type = "Header",
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
Properties = Header3,
ViewProperties = "",
};

AddToViewItems("default", default_header3Component);

Section12 = new Section {
ControlId = "acaf45a6-fffa-493c-b0a1-ed39872caae4",
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
"Column18",
},
Properties = Section12,
ViewProperties = "",
};

AddToViewItems("default", default_section12Component);
Controls.Add(Section12);

Header4 = new Header {
ControlId = "4774cf0a-e32d-3c09-1336-d56e61ccff23",
Name = "Header4",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Header4" },}){
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Ücret Onayı" },{ "en-US", "Header4" },{ "ru-RU", "Header4" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
HeadingType = "h3"
};

Controls.Add(Header4);

BaseComponent default_header4Component = new BaseComponent {
Id = "Header4",
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
Properties = Header4,
ViewProperties = "",
};

AddToViewItems("default", default_header4Component);

Section13 = new Section {
ControlId = "332c88d8-12a5-4c54-88e0-08c035c5db22",
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
"Column17",
},
Properties = Section13,
ViewProperties = "",
};

AddToViewItems("default", default_section13Component);
Controls.Add(Section13);

Tab_2 = new Tab {
ControlId = "78575acc-f199-36ec-3885-09624c848d0b",
Name = "Tab_2",
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
Title = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Uygulama Dosyası" },}){
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

Controls.Add(Tab_2);

BaseComponent default_tab_2Component = new BaseComponent {
Id = "Tab_2",
Type = "Tab",
ParentId = "SupplyTab",
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

HotfixValue = new NumberBox {
ControlId = "f5ccf421-4788-f6f5-6df9-e1bfe2e3b991",
Name = "HotfixValue",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "NumberBox3" },}){
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
EntityPath = "HOTFIXVALUE",
ReadOnly = false,
DefaultReadOnly = false,
Required = false,
Indexable = false,
TabIndex = 0,
Value = null,
Text = "",
Placeholder = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Hotfix" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Right,
Min = 0M,
Max = 99999999999999M,
Step = 1M,
Precision = 0,
UseThousandSeparator = false,
OnlyNumber = false,
SizeType = null,
};

Controls.Add(HotfixValue);

BaseComponent default_hotfixvalueComponent = new BaseComponent {
Id = "HotfixValue",
Type = "NumberBox",
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
Properties = HotfixValue,
ViewProperties = "",
};

AddToViewItems("default", default_hotfixvalueComponent);

Tab_3 = new Tab {
ControlId = "1ca806d1-ecca-7f79-8fd7-42ffd417f16e",
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
OrderNo = 2
};

Controls.Add(Tab_3);

BaseComponent default_tab_3Component = new BaseComponent {
Id = "Tab_3",
Type = "Tab",
ParentId = "SupplyTab",
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
Properties = Tab_3,
ViewProperties = "",
};

AddToViewItems("default", default_tab_3Component);

Tab_4 = new Tab {
ControlId = "e58ccf7c-4479-2aeb-b886-12322e500da5",
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
Title = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Ücretlendirme" },}){
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

Controls.Add(Tab_4);

BaseComponent default_tab_4Component = new BaseComponent {
Id = "Tab_4",
Type = "Tab",
ParentId = "SupplyTab",
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
"Section8",
"Section9",
"Section10",
"Section11",
},
Properties = Tab_4,
ViewProperties = "",
};

AddToViewItems("default", default_tab_4Component);

Tab_5 = new Tab {
ControlId = "e63444e1-5c46-ad28-da8f-48c10e455d11",
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
Title = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Şartlar ve Koşullar" },}){
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

Controls.Add(Tab_5);

BaseComponent default_tab_5Component = new BaseComponent {
Id = "Tab_5",
Type = "Tab",
ParentId = "SupplyTab",
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
"Section7",
},
Properties = Tab_5,
ViewProperties = "",
};

AddToViewItems("default", default_tab_5Component);

Tab_6 = new Tab {
ControlId = "a52ee11f-283e-e72e-ef0d-26c4ee3d2652",
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
Title = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Detay Bilgi" },}){
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

Controls.Add(Tab_6);

BaseComponent default_tab_6Component = new BaseComponent {
Id = "Tab_6",
Type = "Tab",
ParentId = "SupplyTab",
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
"Section2",
"Section4",
"Section5",
},
Properties = Tab_6,
ViewProperties = "",
};

AddToViewItems("default", default_tab_6Component);

Section1 = new Section {
ControlId = "fa6c9cf7-6d6e-4140-a519-3612ad60e1e7",
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
ParentId = "SupplyPage",
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
"Column1",
},
Properties = Section1,
ViewProperties = "",
};

AddToViewItems("default", default_section1Component);
Controls.Add(Section1);

Tab_7 = new Tab {
ControlId = "96a46e0d-fe1d-f5b9-3531-e6bb82b44e93",
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
Title = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Uygulama Dosyası" },}){
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

Controls.Add(Tab_7);

BaseComponent default_tab_7Component = new BaseComponent {
Id = "Tab_7",
Type = "Tab",
ParentId = "SupplyTab",
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
"Section13",
},
Properties = Tab_7,
ViewProperties = "",
};

AddToViewItems("default", default_tab_7Component);

Section2 = new Section {
ControlId = "da725edc-b57d-4930-9229-71c7eb16bcda",
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
"Column2",
},
Properties = Section2,
ViewProperties = "",
};

AddToViewItems("default", default_section2Component);
Controls.Add(Section2);

CheckBox1 = new CheckBox {
ControlId = "825a3167-aae5-d8cc-11fd-2a724b480be0",
Name = "CheckBox1",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = false,
DefaultClientEnabled = false,
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Onaylıyorum" },}){
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
EntityPath = "CheckBox1",
ReadOnly = false,
DefaultReadOnly = false,
Required = false,
Indexable = false,
TabIndex = 0,
Value = false,
Label = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
};

Controls.Add(CheckBox1);

BaseComponent default_checkbox1Component = new BaseComponent {
Id = "CheckBox1",
Type = "CheckBox",
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
Properties = CheckBox1,
ViewProperties = "",
};

AddToViewItems("default", default_checkbox1Component);

Section3 = new Section {
ControlId = "ffecc465-e292-4b09-97b4-21a71b2d2c23",
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
ParentId = "InputGroup1",
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
"Column3",
},
Properties = Section3,
ViewProperties = "",
};

AddToViewItems("default", default_section3Component);
Controls.Add(Section3);

CategorySelection = new ComboBox {
ControlId = "10d0b896-7c2b-b06a-faf9-052c89523e1f",
Name = "CategorySelection",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Kategori" },}){
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
Char = "*",
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
EntityPath = "SL.CATEGORYSELECTION",
ReadOnly = false,
DefaultReadOnly = false,
Required = true,
Indexable = false,
TabIndex = 0,
Value = null,
DataSource = new DataSource {
},
DataSourceType = DataSourceType.Static,
ValueType = PrimitiveType.String,
DateValueFormat = "",
DecimalValuePrecision = 0,
Placeholder = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Kategori Seçiniz..." },}){
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

Controls.Add(CategorySelection);
CategorySelection.Items = new ListItemCollection();

CategorySelection.Items.Add(new ListItem {
Value = "1",
Key = "1",
Icon = @"empty-icon",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Yazılım Desteği" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

CategorySelection.Items.Add(new ListItem {
Value = "2",
Key = "2",
Icon = @"empty-icon",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Danışmanlık" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

BaseComponent default_categoryselectionComponent = new BaseComponent {
Id = "CategorySelection",
Type = "ComboBox",
ParentId = "Column2",
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
Properties = CategorySelection,
ViewProperties = "",
};

AddToViewItems("default", default_categoryselectionComponent);

Section4 = new Section {
ControlId = "392fa2f0-4895-4640-ba97-50b2a5e0594c",
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
"Column5",
"Column6",
"Column7",
},
Properties = Section4,
ViewProperties = "",
};

AddToViewItems("default", default_section4Component);
Controls.Add(Section4);

NumberBox1 = new NumberBox {
ControlId = "b418f164-a9c8-df2d-5753-569532760f99",
Name = "NumberBox1",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "NumberBox1" },}){
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
EntityPath = "NumberBox1",
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
Min = 0M,
Max = 99999999999999M,
Step = 1M,
Precision = 0,
UseThousandSeparator = true,
OnlyNumber = false,
SizeType = null,
};

Controls.Add(NumberBox1);

BaseComponent default_numberbox1Component = new BaseComponent {
Id = "NumberBox1",
Type = "NumberBox",
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
Properties = NumberBox1,
ViewProperties = "",
};

AddToViewItems("default", default_numberbox1Component);

Activity = new Switch {
ControlId = "d1b704e9-cd2e-e028-fa80-55cc7d03c095",
Name = "Activity",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Aktiflik Durumu" },}){
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
EntityPath = "ACTIVITY",
ReadOnly = false,
DefaultReadOnly = false,
Required = false,
Indexable = false,
TabIndex = 0,
Value = true,
};

Controls.Add(Activity);

BaseComponent default_activityComponent = new BaseComponent {
Id = "Activity",
Type = "Switch",
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
Properties = Activity,
ViewProperties = "",
};

AddToViewItems("default", default_activityComponent);

Section5 = new Section {
ControlId = "e0fe71ed-39be-40ab-b801-8981840a45be",
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
"Column8",
},
Properties = Section5,
ViewProperties = "",
};

AddToViewItems("default", default_section5Component);
Controls.Add(Section5);

Section6 = new Section {
ControlId = "179a330c-4f92-4bed-8a38-fc3a3f8761fb",
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
"Column9",
},
Properties = Section6,
ViewProperties = "",
};

AddToViewItems("default", default_section6Component);
Controls.Add(Section6);

Label20 = new Label {
ControlId = "d407bcfc-e012-5f09-2238-d82c2e24fbd8",
Name = "Label20",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Label20" },}){
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
Size = "12",
Color = "rgb(0, 0, 0)",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Müşteri: Müşteri, Hizmet Sağlayıcı'nın hizmetlerini gerektiği şekilde yerine getirmemesi durumunda, yazılı bildirimde bulunarak anlaşmayı feshedebilir." },{ "en-US", "Label20" },{ "ru-RU", "Label20" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
};

Controls.Add(Label20);

BaseComponent default_label20Component = new BaseComponent {
Id = "Label20",
Type = "Label",
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
Properties = Label20,
ViewProperties = "",
};

AddToViewItems("default", default_label20Component);

Section7 = new Section {
ControlId = "15f92e38-8534-437f-ab4d-200b64537207",
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
"Column10",
"Column11",
},
Properties = Section7,
ViewProperties = "",
};

AddToViewItems("default", default_section7Component);
Controls.Add(Section7);

Label21 = new Label {
ControlId = "7738baf6-eee9-576f-f995-3cc0862eab22",
Name = "Label21",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Label21" },}){
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
Size = "12",
Color = "rgb(0, 0, 0)",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Hizmet Sağlayıcı: Hizmet Sağlayıcı, Müşteri'nin ödeme yükümlülüklerini yerine getirmemesi durumunda, yazılı bildirimde bulunarak anlaşmayı feshedebilir." },{ "en-US", "Label21" },{ "ru-RU", "Label21" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
};

Controls.Add(Label21);

BaseComponent default_label21Component = new BaseComponent {
Id = "Label21",
Type = "Label",
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
Properties = Label21,
ViewProperties = "",
};

AddToViewItems("default", default_label21Component);

Section8 = new Section {
ControlId = "101ca785-ba38-4d4a-8356-e30f7f012a66",
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
},
Properties = Section8,
ViewProperties = "",
};

AddToViewItems("default", default_section8Component);
Controls.Add(Section8);

Label10 = new Label {
ControlId = "7bef6cb2-4489-6ef6-ad0e-b124ea97d806",
Name = "Label10",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Label10" },}){
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
Size = "12",
Color = "rgb(0, 0, 0)",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "2. Sorumluluklar" },{ "en-US", "Label10" },{ "ru-RU", "Label10" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
};

Controls.Add(Label10);

BaseComponent default_label10Component = new BaseComponent {
Id = "Label10",
Type = "Label",
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
Properties = Label10,
ViewProperties = "",
};

AddToViewItems("default", default_label10Component);

Label22 = new Label {
ControlId = "492d5d4f-82f1-573a-402a-41175db8373e",
Name = "Label22",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Label22" },}){
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
Size = "12",
Color = "rgb(0, 0, 0)",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "6. Mücbir Sebepler" },{ "en-US", "Label22" },{ "ru-RU", "Label22" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
};

Controls.Add(Label22);

BaseComponent default_label22Component = new BaseComponent {
Id = "Label22",
Type = "Label",
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
Properties = Label22,
ViewProperties = "",
};

AddToViewItems("default", default_label22Component);

DateRangePicker1 = new DateRangePicker {
ControlId = "e19eec5a-b43a-c438-9110-3d89cafe9ddf",
Name = "DateRangePicker1",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "1. Taksit" },}){
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
EntityPath = "DateRangePicker1",
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
StartDate = new DateRangePickerOptions {
Value = null,
AllowEmpty = false,
SetTodayAsDefault = false,
Placeholder = new Dictionary<string, string> {
},
DisabledHours = "",
DisabledMinutes = "",
DisabledSeconds = "",
},
EndDate = new DateRangePickerOptions {
Value = null,
AllowEmpty = false,
SetTodayAsDefault = false,
Placeholder = new Dictionary<string, string> {
},
DisabledHours = "",
DisabledMinutes = "",
DisabledSeconds = "",
},
DisabledDateType = DatePickerDisabledDateTypes.Past,
ActiveDateType = null,
DateLimitType = DateLimitTypes.Disabled,
DisabledDates = new List<string>{
},
DisabledDateRange = 0,
ShowTime = false,
ShowToday = false,
Mode = null,
Format = "",
AllowClear = true,
SizeType = null,
};

Controls.Add(DateRangePicker1);

BaseComponent default_daterangepicker1Component = new BaseComponent {
Id = "DateRangePicker1",
Type = "DateRangePicker",
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
Properties = DateRangePicker1,
ViewProperties = "",
};

AddToViewItems("default", default_daterangepicker1Component);

Section9 = new Section {
ControlId = "6925eab2-438b-44cf-b65c-458659e4100c",
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
"Column13",
"Column14",
"Column15",
},
Properties = Section9,
ViewProperties = "",
};

AddToViewItems("default", default_section9Component);
Controls.Add(Section9);

ComboBox1 = new ComboBox {
ControlId = "fee17700-b3b4-5739-4077-441aace06ebe",
Name = "ComboBox1",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "ComboBox1" },}){
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
EntityPath = "SL.ComboBox1",
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
Placeholder = new MultiLanguageText(){
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

Controls.Add(ComboBox1);
ComboBox1.Items = new ListItemCollection();

ComboBox1.Items.Add(new ListItem {
Value = "Euro",
Key = "Euro",
Icon = @"empty-icon",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Euro" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

ComboBox1.Items.Add(new ListItem {
Value = "Türk Lirası",
Key = "Türk Lirası",
Icon = @"empty-icon",
Selected = true,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Türk Lirası" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

ComboBox1.Items.Add(new ListItem {
Value = "Dolar",
Key = "Dolar",
Icon = @"empty-icon",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Dolar" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

ComboBox1.Items.Add(new ListItem {
Value = "Dinar",
Key = "Dinar",
Icon = @"empty-icon",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Dinar" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

BaseComponent default_combobox1Component = new BaseComponent {
Id = "ComboBox1",
Type = "ComboBox",
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
Properties = ComboBox1,
ViewProperties = "",
};

AddToViewItems("default", default_combobox1Component);

Label11 = new Label {
ControlId = "40f6e477-bc8e-522c-51c0-9b5b0a1153ce",
Name = "Label11",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Label11" },}){
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
Size = "12",
Color = "rgb(0, 0, 0)",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Hizmet Sağlayıcı: Hizmet Sağlayıcı, anlaşmada belirtilen hizmetleri profesyonel bir şekilde ve zamanında sunmayı taahhüt eder." },{ "en-US", "Label11" },{ "ru-RU", "Label11" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
};

Controls.Add(Label11);

BaseComponent default_label11Component = new BaseComponent {
Id = "Label11",
Type = "Label",
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
Properties = Label11,
ViewProperties = "",
};

AddToViewItems("default", default_label11Component);

Label23 = new Label {
ControlId = "904076ab-2f37-e65c-43c3-6ff91e7f68e5",
Name = "Label23",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Label23" },}){
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
Size = "12",
Color = "rgb(0, 0, 0)",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Taraflardan herhangi biri, doğal afetler, savaş, terör saldırıları, grevler veya diğer kontrol edilemeyen durumlar nedeniyle yükümlülüklerini yerine getiremezse, bu durumdan sorumlu tutulamaz." },{ "en-US", "Label23" },{ "ru-RU", "Label23" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
};

Controls.Add(Label23);

BaseComponent default_label23Component = new BaseComponent {
Id = "Label23",
Type = "Label",
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
Properties = Label23,
ViewProperties = "",
};

AddToViewItems("default", default_label23Component);

Column10 = new Column {
ControlId = "7fc691a9-7327-42c3-8f27-dd3cac7ac5ae",
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
"Header1",
"Signature1",
},
Properties = Column10,
ViewProperties = "",
};

AddToViewItems("default", default_column10Component);
Controls.Add(Column10);

DateRangePicker2 = new DateRangePicker {
ControlId = "cd3b732d-e328-03c9-734a-02ba058c152b",
Name = "DateRangePicker2",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "2. Taksit" },}){
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
EntityPath = "DateRangePicker2",
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
StartDate = new DateRangePickerOptions {
Value = null,
AllowEmpty = true,
SetTodayAsDefault = false,
Placeholder = new Dictionary<string, string> {
},
DisabledHours = "",
DisabledMinutes = "",
DisabledSeconds = "",
},
EndDate = new DateRangePickerOptions {
Value = null,
AllowEmpty = true,
SetTodayAsDefault = false,
Placeholder = new Dictionary<string, string> {
},
DisabledHours = "",
DisabledMinutes = "",
DisabledSeconds = "",
},
DisabledDateType = DatePickerDisabledDateTypes.Past,
ActiveDateType = null,
DateLimitType = DateLimitTypes.Disabled,
DisabledDates = new List<string>{
},
DisabledDateRange = 0,
ShowTime = false,
ShowToday = false,
Mode = null,
Format = "",
AllowClear = true,
SizeType = null,
};

Controls.Add(DateRangePicker2);

BaseComponent default_daterangepicker2Component = new BaseComponent {
Id = "DateRangePicker2",
Type = "DateRangePicker",
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
Properties = DateRangePicker2,
ViewProperties = "",
};

AddToViewItems("default", default_daterangepicker2Component);

Label12 = new Label {
ControlId = "3fc3cfb7-4b35-a192-27b5-aea6d9aac96a",
Name = "Label12",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Label12" },}){
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
Size = "12",
Color = "rgb(0, 0, 0)",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", " Müşteri: Müşteri, gerekli bilgileri zamanında ve eksiksiz olarak Hizmet Sağlayıcı'ya iletmeyi kabul eder." },{ "en-US", "Label12" },{ "ru-RU", "Label12" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
};

Controls.Add(Label12);

BaseComponent default_label12Component = new BaseComponent {
Id = "Label12",
Type = "Label",
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
Properties = Label12,
ViewProperties = "",
};

AddToViewItems("default", default_label12Component);

SolutionSelect = new ComboBox {
ControlId = "935d744e-e222-39f5-c85c-4972866adb58",
Name = "SolutionSelect",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
new EventItem {
Name = "OnClick",
MethodName = "SolutionSelect_OnClick",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Çözüm Adı" },}){
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
Char = "*",
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
EntityPath = "SL.SOLUTIONSELECT",
ReadOnly = false,
DefaultReadOnly = false,
Required = true,
Indexable = false,
TabIndex = 0,
Value = null,
DataSource = new DataSource {
Name = "Solutions_Archive_DataSource",
ValueMember = "DOCUMENTID",
DisplayMember = new List<string>{
"SOLUTIONNAME",
},
DisplayFormat = "{{ SOLUTIONNAME }}",
Culture = "",
CultureMember = "",
MultiLanguagePath = "",
RunAtServer = true,
Field = "",
Parameters = new List<DataSourceParameter>{
},
MultiLanguageLoadOptions = new List<MultiLanguageLoadOptions>{
},
ConnectionType = DataSourceConnectionType.MSSQL,
DefaultValue = null,
UseClientCachedData = false,
EnableMultiLanguageDisplayMember = false,
DisplayMemberML = new Dictionary<string, DisplayMemberML> {
},
},
DataSourceType = DataSourceType.Dynamic,
ValueType = PrimitiveType.String,
DateValueFormat = "",
DecimalValuePrecision = 0,
Placeholder = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Çözüm Seçiniz.." },}){
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

Controls.Add(SolutionSelect);
SolutionSelect.Items = new ListItemCollection();

BaseComponent default_solutionselectComponent = new BaseComponent {
Id = "SolutionSelect",
Type = "ComboBox",
ParentId = "Column2",
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
Properties = SolutionSelect,
ViewProperties = "",
};

AddToViewItems("default", default_solutionselectComponent);

Label24 = new Label {
ControlId = "1a154ca6-6927-c02c-03f3-e6e13ddbc4ae",
Name = "Label24",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Label24" },}){
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
Size = "12",
Color = "rgb(0, 0, 0)",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "7. Uyuşmazlıkların Çözümü" },{ "en-US", "Label24" },{ "ru-RU", "Label24" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
};

Controls.Add(Label24);

BaseComponent default_label24Component = new BaseComponent {
Id = "Label24",
Type = "Label",
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
Properties = Label24,
ViewProperties = "",
};

AddToViewItems("default", default_label24Component);

Column11 = new Column {
ControlId = "4f37495d-09fe-4064-8d64-e3de1811e38e",
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
"Header2",
"Signature2",
},
Properties = Column11,
ViewProperties = "",
};

AddToViewItems("default", default_column11Component);
Controls.Add(Column11);

DateRangePicker3 = new DateRangePicker {
ControlId = "b3ebeb8a-8276-6c68-a3ac-9f24d37d1be5",
Name = "DateRangePicker3",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "3. Taksit" },}){
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
EntityPath = "DateRangePicker3",
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
StartDate = new DateRangePickerOptions {
Value = null,
AllowEmpty = true,
SetTodayAsDefault = false,
Placeholder = new Dictionary<string, string> {
},
DisabledHours = "",
DisabledMinutes = "",
DisabledSeconds = "",
},
EndDate = new DateRangePickerOptions {
Value = null,
AllowEmpty = true,
SetTodayAsDefault = false,
Placeholder = new Dictionary<string, string> {
},
DisabledHours = "",
DisabledMinutes = "",
DisabledSeconds = "",
},
DisabledDateType = DatePickerDisabledDateTypes.Past,
ActiveDateType = null,
DateLimitType = DateLimitTypes.Disabled,
DisabledDates = new List<string>{
},
DisabledDateRange = 0,
ShowTime = false,
ShowToday = false,
Mode = null,
Format = "",
AllowClear = true,
SizeType = null,
};

Controls.Add(DateRangePicker3);

BaseComponent default_daterangepicker3Component = new BaseComponent {
Id = "DateRangePicker3",
Type = "DateRangePicker",
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
Properties = DateRangePicker3,
ViewProperties = "",
};

AddToViewItems("default", default_daterangepicker3Component);

FileSelector1 = new FileSelector {
ControlId = "04436f6c-0507-ecc4-7bdf-48f5aa56dba9",
Name = "FileSelector1",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Uygulama Dosyaları" },}){
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
EntityPath = "RD.FileSelector1",
ReadOnly = false,
DefaultReadOnly = false,
Required = false,
Indexable = false,
Files = new List<FileSelectorItem> {
},
AllowSelectMultiple = false,
AllowView = true,
AllowRemove = true,
MaxSelectionCount = 0,
SelectionTargetPath = "GorkemProjects/SupplierIdentification/asset/Uygulama Dosyaları",
SelectionTargetId = "744622",
UploadTargetPath = "GorkemProjects/SupplierIdentification/asset/Uygulama Dosyaları",
UploadTargetId = "744622",
AllowedFileExtensions = new List<string> {
"EAF",
"EPROJ",
"TS",
"CS",
"CSS",
"JS",
"JSON",
"TXT",
"XML",
"LOG",
"DOC",
"DOCM",
"DOCX",
"DOTM",
"DOTX",
"POTM",
"PPAM",
"PPSM",
"PPT",
"PPTM",
"PPTX",
"SLDM",
"XLAM",
"XLS",
"XLSB",
"XLSM",
"XLSX",
"XLTM",
"XLTX",
"PDF",
},
};

Controls.Add(FileSelector1);

BaseComponent default_fileselector1Component = new BaseComponent {
Id = "FileSelector1",
Type = "FileSelector",
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
Properties = FileSelector1,
ViewProperties = "",
};

AddToViewItems("default", default_fileselector1Component);

Label13 = new Label {
ControlId = "4969c2ed-9445-f9b2-8168-3ab85e534c96",
Name = "Label13",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Label13" },}){
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
Size = "12",
Color = "rgb(0, 0, 0)",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "3. Gizlilik" },{ "en-US", "Label13" },{ "ru-RU", "Label13" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
};

Controls.Add(Label13);

BaseComponent default_label13Component = new BaseComponent {
Id = "Label13",
Type = "Label",
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
Properties = Label13,
ViewProperties = "",
};

AddToViewItems("default", default_label13Component);

HTMLDetails = new HTMLTextBox {
ControlId = "d0eaa026-ead4-bfd4-e21e-5bb0645602d9",
Name = "HTMLDetails",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Detay Bilgi" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Top,
Size = new Size {
Width = 120,
Height = 25
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
Char = "*",
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
EntityPath = "ML.HTMLDETAILS",
ReadOnly = false,
DefaultReadOnly = false,
Required = false,
Indexable = false,
TabIndex = 0,
Value = "",
Text = "",
Placeholder = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Detaylı Açıklama Giriniz..." },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
MaxLength = 50,
IsSecretData = false,
EnableMultiLanguageText = true,
ShowCharacterCounter = true,
MultiLanguageText = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Height = null,
CharCounterMax = 4000,
ToolbarBottom = false,
ToolbarType = "basic",
};

Controls.Add(HTMLDetails);

BaseComponent default_htmldetailsComponent = new BaseComponent {
Id = "HTMLDetails",
Type = "HTMLTextBox",
ParentId = "Column2",
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
Properties = HTMLDetails,
ViewProperties = "",
};

AddToViewItems("default", default_htmldetailsComponent);

Label25 = new Label {
ControlId = "fbba874f-a2ae-bd1c-2c6d-e0ea44db7594",
Name = "Label25",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Label25" },}){
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
Size = "12",
Color = "rgb(0, 0, 0)",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Taraflar arasında doğabilecek uyuşmazlıklar, öncelikle dostane bir şekilde çözülmeye çalışılacaktır." },{ "en-US", "Label25" },{ "ru-RU", "Label25" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
};

Controls.Add(Label25);

BaseComponent default_label25Component = new BaseComponent {
Id = "Label25",
Type = "Label",
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
Properties = Label25,
ViewProperties = "",
};

AddToViewItems("default", default_label25Component);

Column12 = new Column {
ControlId = "228763ac-136d-4304-b127-491c7eaba095",
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
"Header3",
},
Properties = Column12,
ViewProperties = "",
};

AddToViewItems("default", default_column12Component);
Controls.Add(Column12);

ImageSelector1 = new FileSelector {
ControlId = "11d0f2dc-bc57-8359-df77-16e5f2c29323",
Name = "ImageSelector1",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Görsel Ekleme" },}){
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
EntityPath = "RD.ImageSelector1",
ReadOnly = false,
DefaultReadOnly = false,
Required = false,
Indexable = false,
Files = new List<FileSelectorItem> {
},
AllowSelectMultiple = false,
AllowView = false,
AllowRemove = true,
MaxSelectionCount = 0,
SelectionTargetPath = "GorkemProjects/SupplierIdentification/asset/Görsel Dosyalar",
SelectionTargetId = "744623",
UploadTargetPath = "GorkemProjects/SupplierIdentification/asset/Görsel Dosyalar",
UploadTargetId = "744623",
AllowedFileExtensions = new List<string> {
"JPEG",
"JPG",
"PNG",
"TIFF",
"WEBP",
"MP4",
"PDF",
},
};

Controls.Add(ImageSelector1);

BaseComponent default_imageselector1Component = new BaseComponent {
Id = "ImageSelector1",
Type = "FileSelector",
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
Properties = ImageSelector1,
ViewProperties = "",
};

AddToViewItems("default", default_imageselector1Component);

Label14 = new Label {
ControlId = "74ecf93b-ace1-07f3-e548-007a407f8213",
Name = "Label14",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Label14" },}){
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
Size = "12",
Color = "rgb(0, 0, 0)",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Hizmet Sağlayıcı, Müşteri'ye ait tüm bilgileri gizli tutmayı ve bu bilgileri yalnızca hizmetin sağlanması amacıyla kullanmayı kabul eder." },{ "en-US", "Label14" },{ "ru-RU", "Label14" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
};

Controls.Add(Label14);

BaseComponent default_label14Component = new BaseComponent {
Id = "Label14",
Type = "Label",
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
Properties = Label14,
ViewProperties = "",
};

AddToViewItems("default", default_label14Component);

Label26 = new Label {
ControlId = "b68adbbc-bf62-529a-f161-47f1110e40be",
Name = "Label26",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Label26" },}){
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
Size = "12",
Color = "rgb(0, 0, 0)",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Anlaşmazlığın çözülmemesi durumunda, Şehir Mahkemeleri ve İcra Daireleri yetkili olacaktır." },{ "en-US", "Label26" },{ "ru-RU", "Label26" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
};

Controls.Add(Label26);

BaseComponent default_label26Component = new BaseComponent {
Id = "Label26",
Type = "Label",
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
Properties = Label26,
ViewProperties = "",
};

AddToViewItems("default", default_label26Component);

Column13 = new Column {
ControlId = "111bd154-147f-4ef1-94d0-dde0dca64498",
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
ParentId = "Section9",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = "30%",
Visible = true,
ClientVisible = true,
Padding = "0px 10px 0px 10px",
},
},
Items = new List<string> {
"Label27",
},
Properties = Column13,
ViewProperties = "",
};

AddToViewItems("default", default_column13Component);
Controls.Add(Column13);

Divider1 = new Divider {
ControlId = "e9bfcaaa-ac36-b4b5-376f-24e5f39f00d1",
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
Properties = Divider1,
ViewProperties = "",
};

AddToViewItems("default", default_divider1Component);

Tags1 = new DataGrid {
ControlId = "f32043de-893d-e563-cff5-f516d1305729",
Name = "Tags1",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Etiketler" },}){
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
VerticalAlign = VerticalAlign.Top,
MarkSettings = new MarkSettings {
Char = "*",
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
EntityPath = "E_SupplierIdentification_SupplyPage_TAGS1",
ReadOnly = false,
DefaultReadOnly = false,
Required = false,
Indexable = false,
DisplayType = DataGridDisplayType.AutoGrow,
PreferredWidthType = DataGridColumnPreferredWidthType.Auto,
SaveMode = SaveMode.Form,
Columns = new DataGridColumnCollection {
},
Rows = new DataGridRowCollection {

},
DataSource = new DataSource {
Name = "",
ValueMember = "",
DisplayMember = new List<string>{
},
DisplayFormat = "",
Culture = "",
CultureMember = "",
MultiLanguagePath = "",
RunAtServer = false,
Field = "",
Parameters = new List<DataSourceParameter>{
},
MultiLanguageLoadOptions = new List<MultiLanguageLoadOptions>{
},
ConnectionType = null,
DefaultValue = null,
UseClientCachedData = true,
EnableMultiLanguageDisplayMember = false,
DisplayMemberML = new Dictionary<string, DisplayMemberML> {
},
},
ColumnSettings = new DataGridColumnOptions {
Orderable = false,
Resizeable = false,
ShowColumnChooser = false,
},
DetailRow = new DataGridDetailRowOptions {
Enabled = false,
},
Editing = new DataGridEditingOptions {
Enabled = false,
ShowAddCommand = true,
ShowEditCommand = false,
ShowDeleteCommand = false,
Mode = DataGridEditingModeType.Row,
},
Filtering = new DataGridFilteringOptions {
Enabled = false,
ShowOperationChooser = false,
HeaderFilterEnabled = false,
},
Grouping = new DataGridGroupingOptions {
Enabled = false,
},
Paging = new DataGridPagingOptions {
Enabled = true,
CurrentPage = 1,
PageSize = 10,
PagingSizes = new List<int> {
10,
20,
30,
40,
},
},
Searching = new DataGridSearchingOptions {
Enabled = false,
},
Selection = new DataGridSelectionOptions {
Enabled = false,
Mode = DataGridSelectionMode.Single,
SelectAllMode = DataGridSelectAllMode.Page,
ShowCheckBoxesMode = DataGridShowCheckBoxMode.OnClick,
ShowSelectAll = false,
Type = DataGridSelectionType.Rowselect,
DisabledValueColumnName = "",
DisabledValueMatchers = new List<object>{
},},
Sorting = new DataGridSortingOptions {
Enabled = false,
AllSortingColumns = true,
Mode = DataGridSortingMode.None,
},
TreeView = new DataGridTreeViewOptions {
Enabled = false,
Id = "",
ParentId = "",
},
AlternateColor = new DataGridAlternateColorOptions {
Enabled = true,
Color = "rgba(33, 150, 243, 0.05)",
},
RowDragging = new DataGridRowDraggingOptions {
Enabled = false,
ShowDragIcons = false,
},
ToolbarActionButtons = new List<ExecuteActionButton> {
},
FillForm = null,
Height = null,
ExportToExcel = false,
GridBorder = true,
ColumnVerticalBorder = true,
VirtualScrolling = false,
HoverStateEnabled = false,
ShowClearAllButton = false,
ColumnAutoWidth = true,
SaveAction = false,
WordWrapEnabled = false,
ColumnHidingEnabled = false,
ColumnFixingEnabled = false,
CacheSettingsEnabled = false,
GridLines = DataGridLineType.Horizontal,
DataSourceType = DataSourceType.Dynamic,
HiddenRowColumnName = null,
HiddenRowValueMatchers = new DataGridHiddenRowValueOptions {
},
};

Controls.Add(Tags1);

BaseComponent default_tags1Component = new BaseComponent {
Id = "Tags1",
Type = "DataGrid",
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
Properties = Tags1,
ViewProperties = "",
};

AddToViewItems("default", default_tags1Component);

MajorValue = new NumberBox {
ControlId = "6402baf1-a6bb-aa52-c0a7-1e048d3629d6",
Name = "MajorValue",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Versiyon" },}){
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
Char = "*",
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
EntityPath = "MAJORVALUE",
ReadOnly = false,
DefaultReadOnly = false,
Required = false,
Indexable = false,
TabIndex = 0,
Value = null,
Text = "",
Placeholder = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Major" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Right,
Min = 1M,
Max = 99999999999999M,
Step = 1M,
Precision = 0,
UseThousandSeparator = false,
OnlyNumber = false,
SizeType = null,
};

Controls.Add(MajorValue);

BaseComponent default_majorvalueComponent = new BaseComponent {
Id = "MajorValue",
Type = "NumberBox",
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
},
Properties = MajorValue,
ViewProperties = "",
};

AddToViewItems("default", default_majorvalueComponent);

Label15 = new Label {
ControlId = "5b5b6bfc-dff9-0989-1a52-d33d41a8a508",
Name = "Label15",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Label15" },}){
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
Size = "12",
Color = "rgb(0, 0, 0)",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Bu gizlilik yükümlülüğü, anlaşmanın sona ermesinden sonra da devam eder." },{ "en-US", "Label15" },{ "ru-RU", "Label15" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
};

Controls.Add(Label15);

BaseComponent default_label15Component = new BaseComponent {
Id = "Label15",
Type = "Label",
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
Properties = Label15,
ViewProperties = "",
};

AddToViewItems("default", default_label15Component);

Label27 = new Label {
ControlId = "c661e1d1-01e4-c1c6-b87c-6cffedea4ca8",
Name = "Label27",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Label27" },}){
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
Size = "12",
Color = "rgb(0, 0, 0)",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Anlaşmaya varılan çözüm ve hizmetlere binaen belirlenen ücret :" },{ "en-US", "Label27" },{ "ru-RU", "Label27" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Center,
};

Controls.Add(Label27);

BaseComponent default_label27Component = new BaseComponent {
Id = "Label27",
Type = "Label",
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
Properties = Label27,
ViewProperties = "",
};

AddToViewItems("default", default_label27Component);

Column14 = new Column {
ControlId = "a0daf897-4fc3-4651-90da-bcfee7e70c37",
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
ParentId = "Section9",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = "30%",
Visible = true,
ClientVisible = true,
Padding = "0px 10px 0px 10px",
},
},
Items = new List<string> {
"NumberBox1",
},
Properties = Column14,
ViewProperties = "",
};

AddToViewItems("default", default_column14Component);
Controls.Add(Column14);

Divider2 = new Divider {
ControlId = "46456f00-3737-599d-cd98-8979d6425459",
Name = "Divider2",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Divider2" },}){
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

Controls.Add(Divider2);

BaseComponent default_divider2Component = new BaseComponent {
Id = "Divider2",
Type = "Divider",
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
Properties = Divider2,
ViewProperties = "",
};

AddToViewItems("default", default_divider2Component);

Signature1 = new Signature {
ControlId = "cea7ad42-4a31-e1a6-057f-4d0f32d892fb",
Name = "Signature1",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Hizmet Sağlayıcı İmzası" },}){
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
VerticalAlign = VerticalAlign.Bottom,
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
EntityPath = "Signature1",
ReadOnly = false,
DefaultReadOnly = false,
Required = false,
Indexable = false,
TabIndex = 0,
Value = null,
Width = 300,
Height = 150,
DotSize = 2,
MinPenSize = 0.5,
MaxPenSize = 2.5,
PenColor = "rgba(0, 0, 0, 1)",
ShowLegalWarning = true,
ShowBorder = true,
};

Controls.Add(Signature1);

BaseComponent default_signature1Component = new BaseComponent {
Id = "Signature1",
Type = "Signature",
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
Properties = Signature1,
ViewProperties = "",
};

AddToViewItems("default", default_signature1Component);

Label16 = new Label {
ControlId = "11c74787-dda3-1d2e-3948-0bea0c62bfd1",
Name = "Label16",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Label16" },}){
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
Size = "12",
Color = "rgb(0, 0, 0)",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "4. Ödeme Şartları" },{ "en-US", "Label16" },{ "ru-RU", "Label16" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
};

Controls.Add(Label16);

BaseComponent default_label16Component = new BaseComponent {
Id = "Label16",
Type = "Label",
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
Properties = Label16,
ViewProperties = "",
};

AddToViewItems("default", default_label16Component);

Label28 = new Label {
ControlId = "30d1b5a8-f103-34cb-3619-99efc4849207",
Name = "Label28",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Label28" },}){
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
Size = "12",
Color = "rgb(0, 0, 0)",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Müşteri, Hizmet Sağlayıcı tarafından sağlanacak hizmetler karşılığında üst kısımda belirlenen  tutardaki ücreti kabul ettiğini ve bu ücreti ödeme yükümlülüğünü üstlendiğini onaylar. Müşteri, bu ücretin sözleşme kapsamındaki tüm hizmetleri kapsadığını ve ek hizmet taleplerinin, taraflar arasında yapılacak ek anlaşmalarla belirlenmesi gerektiğini kabul eder." },{ "en-US", "Label28" },{ "ru-RU", "Label28" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
};

Controls.Add(Label28);

BaseComponent default_label28Component = new BaseComponent {
Id = "Label28",
Type = "Label",
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
Properties = Label28,
ViewProperties = "",
};

AddToViewItems("default", default_label28Component);

Column15 = new Column {
ControlId = "10814fb3-9c65-4932-a987-7a08d28afd73",
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
Width = "20%",
Visible = true,
ClientVisible = true,
Padding = "0px 10px 0px 10px",
},
},
Items = new List<string> {
"ComboBox1",
},
Properties = Column15,
ViewProperties = "",
};

AddToViewItems("default", default_column15Component);
Controls.Add(Column15);

Divider3 = new Divider {
ControlId = "524b742a-af85-4fe8-7545-df110a8481a0",
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
Properties = Divider3,
ViewProperties = "",
};

AddToViewItems("default", default_divider3Component);

Signature2 = new Signature {
ControlId = "5d7b20d5-12fb-e6fa-5b30-e02922a954d6",
Name = "Signature2",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Signature2" },}){
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
EntityPath = "Signature2",
ReadOnly = false,
DefaultReadOnly = false,
Required = false,
Indexable = false,
TabIndex = 0,
Value = null,
Width = 300,
Height = 150,
DotSize = 2,
MinPenSize = 0.5,
MaxPenSize = 2.5,
PenColor = "rgba(0, 0, 0, 1)",
ShowLegalWarning = true,
ShowBorder = true,
};

Controls.Add(Signature2);

BaseComponent default_signature2Component = new BaseComponent {
Id = "Signature2",
Type = "Signature",
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
Properties = Signature2,
ViewProperties = "",
};

AddToViewItems("default", default_signature2Component);

Label17 = new Label {
ControlId = "2a7a7e3e-675e-2c82-1ae3-12aff36a471d",
Name = "Label17",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Label17" },}){
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
Size = "12",
Color = "rgb(0, 0, 0)",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Müşteri, Hizmet Sağlayıcı'ya hizmetlerin karşılığında belirtilen toplam tutarı ödemeyi kabul eder." },{ "en-US", "Label17" },{ "ru-RU", "Label17" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
};

Controls.Add(Label17);

BaseComponent default_label17Component = new BaseComponent {
Id = "Label17",
Type = "Label",
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
Properties = Label17,
ViewProperties = "",
};

AddToViewItems("default", default_label17Component);

Column16 = new Column {
ControlId = "50a8d0a5-56e3-4cb7-98a4-6087e3042588",
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
"Divider8",
"Header4",
"Divider9",
"Label28",
"CheckBox1",
},
Properties = Column16,
ViewProperties = "",
};

AddToViewItems("default", default_column16Component);
Controls.Add(Column16);

Divider4 = new Divider {
ControlId = "7fbd521f-5aa4-ffb4-b824-853a56aaf768",
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
Properties = Divider4,
ViewProperties = "",
};

AddToViewItems("default", default_divider4Component);

Column1 = new Column {
ControlId = "f789710e-4a6a-4db5-9493-ba0f10e270ab",
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
Width = null,
Visible = true,
ClientVisible = true,
Padding = "0px 10px 0px 10px",
},
},
Items = new List<string> {
"SupplyTab",
"ACTIVITY2",
},
Properties = Column1,
ViewProperties = "",
};

AddToViewItems("default", default_column1Component);
Controls.Add(Column1);

ApplicationName = new ComboBox {
ControlId = "287fe8cc-6d03-1f86-df58-2b3431540706",
Name = "ApplicationName",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Sistem Adı" },}){
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
Char = "*",
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
EntityPath = "SL.APPLICATIONNAME",
ReadOnly = false,
DefaultReadOnly = false,
Required = true,
Indexable = false,
TabIndex = 0,
Value = null,
DataSource = new DataSource {
},
DataSourceType = DataSourceType.Static,
ValueType = PrimitiveType.String,
DateValueFormat = "",
DecimalValuePrecision = 0,
Placeholder = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Sistem Seçiniz..." },}){
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

Controls.Add(ApplicationName);
ApplicationName.Items = new ListItemCollection();

ApplicationName.Items.Add(new ListItem {
Value = "Synergy_1",
Key = "Synergy_1",
Icon = @"empty-icon",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "grafiksel raporlama (BI – Dashboard)" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

ApplicationName.Items.Add(new ListItem {
Value = "Synergy_2",
Key = "Synergy_2",
Icon = @"empty-icon",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "belge yönetimi (EBYS)" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

ApplicationName.Items.Add(new ListItem {
Value = "Synergy_3",
Key = "Synergy_3",
Icon = @"empty-icon",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Capture (Sayısallaştırma)" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

ApplicationName.Items.Add(new ListItem {
Value = "eBA_1",
Key = "eBA_1",
Icon = @"empty-icon",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "İş Süreçleri Otomasyonu" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

ApplicationName.Items.Add(new ListItem {
Value = "eBA_2",
Key = "eBA_2",
Icon = @"empty-icon",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Doküman Yönetim Sistemi" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

ApplicationName.Items.Add(new ListItem {
Value = "eBA_3",
Key = "eBA_3",
Icon = @"empty-icon",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Elektronik Belge Yönetim Sistemi" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

ApplicationName.Items.Add(new ListItem {
Value = "eBA_4",
Key = "eBA_4",
Icon = @"empty-icon",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Sayısallaştırma Yönetimi" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

ApplicationName.Items.Add(new ListItem {
Value = "eBA_5",
Key = "eBA_5",
Icon = @"empty-icon",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Dashboard (Grafiksel Raporlama)" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

ApplicationName.Items.Add(new ListItem {
Value = "QDMS_1",
Key = "QDMS_1",
Icon = @"empty-icon",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Entegre Yönetim Sistemi (IMS)" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

ApplicationName.Items.Add(new ListItem {
Value = "QDMS_2",
Key = "QDMS_2",
Icon = @"empty-icon",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Kalite Yönetim Sistemi (QMS)" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

ApplicationName.Items.Add(new ListItem {
Value = "QDMS_3",
Key = "QDMS_3",
Icon = @"empty-icon",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Çevre ve İş Sağlığı Güvenliği Yönetim Sistemi (EHS)" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

ApplicationName.Items.Add(new ListItem {
Value = "QDMS_4",
Key = "QDMS_4",
Icon = @"empty-icon",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Bilgi Güvenliği Yönetim Sistemi (ISMS)" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

ApplicationName.Items.Add(new ListItem {
Value = "BEAM_1",
Key = "BEAM_1",
Icon = @"empty-icon",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Varlık Yönetimi" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

ApplicationName.Items.Add(new ListItem {
Value = "BEAM_2",
Key = "BEAM_2",
Icon = @"empty-icon",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Bakım Onarım Yönetimi" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

ApplicationName.Items.Add(new ListItem {
Value = "BEAM_3",
Key = "BEAM_3",
Icon = @"empty-icon",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Malzeme Yönetimi" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

ApplicationName.Items.Add(new ListItem {
Value = "BEAM_4",
Key = "BEAM_4",
Icon = @"empty-icon",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Personel Yönetimi" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

ApplicationName.Items.Add(new ListItem {
Value = "BEAM_5",
Key = "BEAM_5",
Icon = @"empty-icon",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Satın Alma Yönetimi" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

ApplicationName.Items.Add(new ListItem {
Value = "Ensemble_1",
Key = "Ensemble_1",
Icon = @"empty-icon",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Performans Yönetimi" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

ApplicationName.Items.Add(new ListItem {
Value = "Ensemble_2",
Key = "Ensemble_2",
Icon = @"empty-icon",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Balanced Score Card (BSC)" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

ApplicationName.Items.Add(new ListItem {
Value = "QGRC_1",
Key = "QGRC_1",
Icon = @"empty-icon",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Baz Modül (QGRC Server)" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

ApplicationName.Items.Add(new ListItem {
Value = "QGRC_2",
Key = "QGRC_2",
Icon = @"empty-icon",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "QGRC Çözüm Paketi" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

BaseComponent default_applicationnameComponent = new BaseComponent {
Id = "ApplicationName",
Type = "ComboBox",
ParentId = "Column2",
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
Properties = ApplicationName,
ViewProperties = "",
};

AddToViewItems("default", default_applicationnameComponent);

Label18 = new Label {
ControlId = "eb04fe91-5f6b-4dd2-9310-5a4e50b27b39",
Name = "Label18",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Label18" },}){
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
Size = "12",
Color = "rgb(0, 0, 0)",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Ödemeler, aşağıdaki ödeme planına göre yapılacaktır:" },{ "en-US", "Label18" },{ "ru-RU", "Label18" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
};

Controls.Add(Label18);

BaseComponent default_label18Component = new BaseComponent {
Id = "Label18",
Type = "Label",
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
Properties = Label18,
ViewProperties = "",
};

AddToViewItems("default", default_label18Component);

Column17 = new Column {
ControlId = "9d83eb6b-b060-486d-b9e6-5469658f996c",
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
"FileSelector1",
},
Properties = Column17,
ViewProperties = "",
};

AddToViewItems("default", default_column17Component);
Controls.Add(Column17);

Divider5 = new Divider {
ControlId = "5b10420c-36da-6780-2c4f-3283657ee2ff",
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
Properties = Divider5,
ViewProperties = "",
};

AddToViewItems("default", default_divider5Component);

MinorValue = new NumberBox {
ControlId = "5e589d06-8fb2-5394-1f34-ef9dc0d458a0",
Name = "MinorValue",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "NumberBox2" },}){
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
EntityPath = "MINORVALUE",
ReadOnly = false,
DefaultReadOnly = false,
Required = false,
Indexable = false,
TabIndex = 0,
Value = null,
Text = "",
Placeholder = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Minor" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Right,
Min = 0M,
Max = 99999999999999M,
Step = 1M,
Precision = 0,
UseThousandSeparator = false,
OnlyNumber = false,
SizeType = null,
};

Controls.Add(MinorValue);

BaseComponent default_minorvalueComponent = new BaseComponent {
Id = "MinorValue",
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
Properties = MinorValue,
ViewProperties = "",
};

AddToViewItems("default", default_minorvalueComponent);

Column2 = new Column {
ControlId = "151b47b2-d1ee-493d-a91a-43178d46c7c9",
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
ParentId = "Section2",
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
"SolutionSelect",
"ApplicationName",
"CategorySelection",
"SectorSelection",
"SummaryInformation",
"HTMLDetails",
"Properties1",
"CompatibleVersion",
},
Properties = Column2,
ViewProperties = "",
};

AddToViewItems("default", default_column2Component);
Controls.Add(Column2);

Label19 = new Label {
ControlId = "57de9174-5011-8f25-53c7-7aa8b93ad375",
Name = "Label19",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Label19" },}){
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
Size = "12",
Color = "rgb(0, 0, 0)",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "5. Fesih Koşulları" },{ "en-US", "Label19" },{ "ru-RU", "Label19" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
};

Controls.Add(Label19);

BaseComponent default_label19Component = new BaseComponent {
Id = "Label19",
Type = "Label",
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
Properties = Label19,
ViewProperties = "",
};

AddToViewItems("default", default_label19Component);

Column18 = new Column {
ControlId = "06e6a9af-ab29-470d-b788-2d18bce54b80",
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
"ImageSelector1",
},
Properties = Column18,
ViewProperties = "",
};

AddToViewItems("default", default_column18Component);
Controls.Add(Column18);

Divider6 = new Divider {
ControlId = "b5113066-027f-ed35-cb25-c2f8d9c25c21",
Name = "Divider6",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Divider6" },}){
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

Controls.Add(Divider6);

BaseComponent default_divider6Component = new BaseComponent {
Id = "Divider6",
Type = "Divider",
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
Properties = Divider6,
ViewProperties = "",
};

AddToViewItems("default", default_divider6Component);

Column3 = new Column {
ControlId = "cfe6c637-bdcd-4a24-807a-55c368a70c51",
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
ParentId = "Section3",
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
Properties = Column3,
ViewProperties = "",
};

AddToViewItems("default", default_column3Component);
Controls.Add(Column3);

Label1 = new Label {
ControlId = "39bad8b7-0f33-21ad-327e-0009d34debdc",
Name = "Label1",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Label1" },}){
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
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "20",
Color = "rgb(0, 0, 0)",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "ŞARTLAR VE KOŞULLAR" },{ "en-US", "Label1" },{ "ru-RU", "Label1" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Center,
};

Controls.Add(Label1);

BaseComponent default_label1Component = new BaseComponent {
Id = "Label1",
Type = "Label",
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
Properties = Label1,
ViewProperties = "",
};

AddToViewItems("default", default_label1Component);

ClientVisible = true;
ProjectName = "SupplierIdentification";
ProjectId = "561223b1-10f4-4f7e-88c7-35378b4dd997";
EntityPath = "";
ActiveView = "default";
Version = 19;
ReadOnly = false;
DefaultReadOnly = false;
Text = new Dictionary<string, string> {
{ "tr-TR", "SupplyPage" },
{ "en-US", "SupplyPage" },
{ "ru-RU", "SupplyPage" },
{ "az-Latn-AZ", "SupplyPage" },
};
Name = "SupplyPage";
FormId = "67c8278c-176a-4b30-bc78-1d0e41f1a8cc";
FormType = FormType.Standard;
ServerEvents = new List<EventItem> {
};
ClientEvents = new List<EventItem> {
new EventItem {
Name = "OnToolbarButtonClicked",
MethodName = "SupplyPage_OnToolbarButtonClicked",
Async = null
},
new EventItem {
Name = "OnMessageReceived",
MethodName = "SupplyPage_OnMessageReceived",
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
Validate = true,
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
Key = "AddNewSolution",
Name = "AddNewSolution",
Icon = "add",
Enabled = false,
DefaultEnabled = false,
Validate = false,
Caption = new Dictionary<string, string> {
{ "tr-TR", "Yeni Çözüm Ekle" },
},
View = "",
IsServerPrint = false,
},
};
Variables = new Dictionary<string, object> {
};
Rules = new Dictionary<string, Rule> {
{
"FormRequiredFields",
new Rule {
Id = "FormRequiredFields",
Name = "FormRequiredFields",
Enabled = true,
OrderNo = 0,
Statements = new List<BaseStatement> {
new IfStatement {
Id = "FormRequiredFields_Statement_default_SolutionSelect",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_default_SolutionSelect",
Name = "SolutionSelect_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Çözüm Adı: Gerekli alan"
},
{
"en-US",
"Çözüm Adı: Required field"
},
{
"ru-RU",
"Çözüm Adı: Обязательное поле"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"SolutionSelect",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "FormRequiredFields_ConditionGroup_default_SolutionSelect",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "FormRequiredFields_Condition_default_SolutionSelect_value",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "SolutionSelect",
PropertyName = "value",
Type = FieldValueType.String,
},
Operation = OperationType.Null,
Value = null
},
new ValueEntryCondition {
Id = "FormRequiredFields_View_Condition_default_SolutionSelect",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "SupplyPage",
PropertyName = "activeView",
Type = FieldValueType.String,
},
Operation = OperationType.Equals,
Value = "default"
},
},
Children = new List<BaseConditionGroup> {
},
},
},
new IfStatement {
Id = "FormRequiredFields_Statement_default_ApplicationName",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_default_ApplicationName",
Name = "ApplicationName_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Sistem Adı: Gerekli alan"
},
{
"en-US",
"Sistem Adı: Required field"
},
{
"ru-RU",
"Sistem Adı: Обязательное поле"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"ApplicationName",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "FormRequiredFields_ConditionGroup_default_ApplicationName",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "FormRequiredFields_Condition_default_ApplicationName_value",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "ApplicationName",
PropertyName = "value",
Type = FieldValueType.String,
},
Operation = OperationType.Null,
Value = null
},
new ValueEntryCondition {
Id = "FormRequiredFields_View_Condition_default_ApplicationName",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "SupplyPage",
PropertyName = "activeView",
Type = FieldValueType.String,
},
Operation = OperationType.Equals,
Value = "default"
},
},
Children = new List<BaseConditionGroup> {
},
},
},
new IfStatement {
Id = "FormRequiredFields_Statement_default_SectorSelection",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_default_SectorSelection",
Name = "SectorSelection_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Sektör: Gerekli alan"
},
{
"en-US",
"Sektör: Required field"
},
{
"ru-RU",
"Sektör: Обязательное поле"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"SectorSelection",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "FormRequiredFields_ConditionGroup_default_SectorSelection",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "FormRequiredFields_Condition_default_SectorSelection_value",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "SectorSelection",
PropertyName = "value",
Type = FieldValueType.String,
},
Operation = OperationType.Null,
Value = null
},
new ValueEntryCondition {
Id = "FormRequiredFields_View_Condition_default_SectorSelection",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "SupplyPage",
PropertyName = "activeView",
Type = FieldValueType.String,
},
Operation = OperationType.Equals,
Value = "default"
},
},
Children = new List<BaseConditionGroup> {
},
},
},
new IfStatement {
Id = "FormRequiredFields_Statement_default_SummaryInformation",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_default_SummaryInformation",
Name = "SummaryInformation_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Özet Bilgi: Gerekli alan"
},
{
"en-US",
"Özet Bilgi: Required field"
},
{
"ru-RU",
"Özet Bilgi: Обязательное поле"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"SummaryInformation",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "FormRequiredFields_ConditionGroup_default_SummaryInformation",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "FormRequiredFields_Condition_default_SummaryInformation_value",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "SummaryInformation",
PropertyName = "value",
Type = FieldValueType.String,
},
Operation = OperationType.Null,
Value = null
},
new ValueEntryCondition {
Id = "FormRequiredFields_View_Condition_default_SummaryInformation",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "SupplyPage",
PropertyName = "activeView",
Type = FieldValueType.String,
},
Operation = OperationType.Equals,
Value = "default"
},
},
Children = new List<BaseConditionGroup> {
},
},
},
new IfStatement {
Id = "FormRequiredFields_Statement_default_CompatibleVersion",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_default_CompatibleVersion",
Name = "CompatibleVersion_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Uyumlu Versiyon: Gerekli alan"
},
{
"en-US",
"Uyumlu Versiyon: Required field"
},
{
"ru-RU",
"Uyumlu Versiyon: Обязательное поле"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"CompatibleVersion",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "FormRequiredFields_ConditionGroup_default_CompatibleVersion",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "FormRequiredFields_Condition_default_CompatibleVersion_value",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "CompatibleVersion",
PropertyName = "value",
Type = FieldValueType.String,
},
Operation = OperationType.Null,
Value = null
},
new ValueEntryCondition {
Id = "FormRequiredFields_View_Condition_default_CompatibleVersion",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "SupplyPage",
PropertyName = "activeView",
Type = FieldValueType.String,
},
Operation = OperationType.Equals,
Value = "default"
},
},
Children = new List<BaseConditionGroup> {
},
},
},
new IfStatement {
Id = "FormRequiredFields_Statement_default_CategorySelection",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_default_CategorySelection",
Name = "CategorySelection_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Kategori: Gerekli alan"
},
{
"en-US",
"Kategori: Required field"
},
{
"ru-RU",
"Kategori: Обязательное поле"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"CategorySelection",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "FormRequiredFields_ConditionGroup_default_CategorySelection",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "FormRequiredFields_Condition_default_CategorySelection_value",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "CategorySelection",
PropertyName = "value",
Type = FieldValueType.String,
},
Operation = OperationType.Null,
Value = null
},
new ValueEntryCondition {
Id = "FormRequiredFields_View_Condition_default_CategorySelection",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "SupplyPage",
PropertyName = "activeView",
Type = FieldValueType.String,
},
Operation = OperationType.Equals,
Value = "default"
},
},
Children = new List<BaseConditionGroup> {
},
},
},
},
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_default_SolutionSelect",
Name = "SolutionSelect_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Çözüm Adı: Gerekli alan"
},
{
"en-US",
"Çözüm Adı: Required field"
},
{
"ru-RU",
"Çözüm Adı: Обязательное поле"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"SolutionSelect",
},
},
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_default_ApplicationName",
Name = "ApplicationName_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Sistem Adı: Gerekli alan"
},
{
"en-US",
"Sistem Adı: Required field"
},
{
"ru-RU",
"Sistem Adı: Обязательное поле"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"ApplicationName",
},
},
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_default_SectorSelection",
Name = "SectorSelection_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Sektör: Gerekli alan"
},
{
"en-US",
"Sektör: Required field"
},
{
"ru-RU",
"Sektör: Обязательное поле"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"SectorSelection",
},
},
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_default_SummaryInformation",
Name = "SummaryInformation_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Özet Bilgi: Gerekli alan"
},
{
"en-US",
"Özet Bilgi: Required field"
},
{
"ru-RU",
"Özet Bilgi: Обязательное поле"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"SummaryInformation",
},
},
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_default_CompatibleVersion",
Name = "CompatibleVersion_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Uyumlu Versiyon: Gerekli alan"
},
{
"en-US",
"Uyumlu Versiyon: Required field"
},
{
"ru-RU",
"Uyumlu Versiyon: Обязательное поле"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"CompatibleVersion",
},
},
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_default_CategorySelection",
Name = "CategorySelection_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Kategori: Gerekli alan"
},
{
"en-US",
"Kategori: Required field"
},
{
"ru-RU",
"Kategori: Обязательное поле"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"CategorySelection",
},
},
},
TriggerEvents = new List<string> {
"SupplyPage.client.OnBeforeSave",
"SupplyPage.server.OnBeforeSave",
"SupplyPage.client.OnToolbarButtonClicked",
"SupplyPage.server.OnToolbarButtonClicked",
}
}
},
{
"908d0910-a120-47a6-936c-660a2bb77dcf",
new Rule {
Id = "908d0910-a120-47a6-936c-660a2bb77dcf",
Name = "SectorSelection_RequirementRule",
Enabled = true,
OrderNo = 0,
Statements = new List<BaseStatement> {
new IfStatement {
Id = "d3a15d28-bb44-4e63-ac43-726de9555cb9",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "cfd00324-b915-49d1-a18a-3a6c4a84d3b5",
Name = "SectorSelection_RequirementAction",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"SectorSelection alanı zorunludur"
},
{
"en-US",
"SectorSelection is required"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"SectorSelection",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "cf9805e0-d334-46cc-8161-f6e3a30c9b8a",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "1312bdd4-8620-4bed-8c79-e770bb05851c",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "SectorSelection",
PropertyName = "Value",
Type = FieldValueType.String,
},
Operation = OperationType.Null,
Value = null
},
},
Children = new List<BaseConditionGroup> {
},
},
},
new ElseStatement {
Id = "078a3cb0-a543-4ee3-89ee-0a512e621740",
TypeName = StatementType.ElseStatement,
Enabled = true,
Actions = new List<BaseAction> {
},
},
},
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "cfd00324-b915-49d1-a18a-3a6c4a84d3b5",
Name = "SectorSelection_RequirementAction",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Error,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"SectorSelection alanı zorunludur"
},
{
"en-US",
"SectorSelection is required"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
},
},
},
TriggerEvents = new List<string> {
"SupplyPage.server.OnBeforeSave",
}
}
},
{
"763c194d-f55b-43fc-bff6-067716b77ccd",
new Rule {
Id = "763c194d-f55b-43fc-bff6-067716b77ccd",
Name = "CategorySelection_RequirementRule",
Enabled = true,
OrderNo = 0,
Statements = new List<BaseStatement> {
new IfStatement {
Id = "ad66e195-353b-42ad-a2b9-7e0e28ae717e",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "5ad9bdf5-15d2-40fc-a9c4-f426a5851dd4",
Name = "CategorySelection_RequirementAction",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"CategorySelection alanı zorunludur"
},
{
"en-US",
"CategorySelection is required"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"CategorySelection",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "6009ad3c-63e1-445c-b1b5-970b28db8bf2",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "8f3ee65b-dec0-4fd8-88be-7e3b084bd3a5",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "CategorySelection",
PropertyName = "Value",
Type = FieldValueType.String,
},
Operation = OperationType.Null,
Value = null
},
},
Children = new List<BaseConditionGroup> {
},
},
},
new ElseStatement {
Id = "8735e6c8-7c6a-4e0a-ab4d-f23979bb81c0",
TypeName = StatementType.ElseStatement,
Enabled = true,
Actions = new List<BaseAction> {
},
},
},
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "5ad9bdf5-15d2-40fc-a9c4-f426a5851dd4",
Name = "CategorySelection_RequirementAction",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Error,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"CategorySelection alanı zorunludur"
},
{
"en-US",
"CategorySelection is required"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
},
},
},
TriggerEvents = new List<string> {
"SupplyPage.server.OnBeforeSave",
}
}
},
{
"f8ac433d-9bf2-41d9-a229-a849aaeb4522",
new Rule {
Id = "f8ac433d-9bf2-41d9-a229-a849aaeb4522",
Name = "SolutionSelect_RequirementRule",
Enabled = true,
OrderNo = 0,
Statements = new List<BaseStatement> {
new IfStatement {
Id = "72a90244-fcca-45d6-8b0d-e6ec8da6d10a",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "8e735578-b729-466c-9b98-ec1e1b6a61a5",
Name = "SolutionSelect_RequirementAction",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"SolutionSelect alanı zorunludur"
},
{
"en-US",
"SolutionSelect is required"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"SolutionSelect",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "bd3caae2-034e-4568-a06e-1b4e2933d8a2",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "13f0ebb4-bad1-444f-b37f-719d700b0abd",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "SolutionSelect",
PropertyName = "Value",
Type = FieldValueType.String,
},
Operation = OperationType.Null,
Value = null
},
},
Children = new List<BaseConditionGroup> {
},
},
},
new ElseStatement {
Id = "381f837a-3864-4318-9494-8ab2e8bf571e",
TypeName = StatementType.ElseStatement,
Enabled = true,
Actions = new List<BaseAction> {
},
},
},
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "8e735578-b729-466c-9b98-ec1e1b6a61a5",
Name = "SolutionSelect_RequirementAction",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Error,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"SolutionSelect alanı zorunludur"
},
{
"en-US",
"SolutionSelect is required"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
},
},
},
TriggerEvents = new List<string> {
"SupplyPage.server.OnBeforeSave",
}
}
},
{
"a5bc4f5a-74c0-4a7f-ad3f-dc778d8af66e",
new Rule {
Id = "a5bc4f5a-74c0-4a7f-ad3f-dc778d8af66e",
Name = "ApplicationName_RequirementRule",
Enabled = true,
OrderNo = 0,
Statements = new List<BaseStatement> {
new IfStatement {
Id = "e36b6130-c26a-4ded-b203-329f698e8f15",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "66b06acc-4211-499a-aa7e-c938fcf0605a",
Name = "ApplicationName_RequirementAction",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"ApplicationName alanı zorunludur"
},
{
"en-US",
"ApplicationName is required"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"ApplicationName",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "29310743-caf5-46c5-9d9e-add8c14ca98f",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "fcd6fc97-c5df-45c5-b22d-30e3e55c8efe",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "ApplicationName",
PropertyName = "Value",
Type = FieldValueType.String,
},
Operation = OperationType.Null,
Value = null
},
},
Children = new List<BaseConditionGroup> {
},
},
},
new ElseStatement {
Id = "b1675e47-ef46-42b0-8953-b0c2143105f5",
TypeName = StatementType.ElseStatement,
Enabled = true,
Actions = new List<BaseAction> {
},
},
},
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "66b06acc-4211-499a-aa7e-c938fcf0605a",
Name = "ApplicationName_RequirementAction",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Error,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"ApplicationName alanı zorunludur"
},
{
"en-US",
"ApplicationName is required"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
},
},
},
TriggerEvents = new List<string> {
"SupplyPage.server.OnBeforeSave",
}
}
},
};
CheckInCheckOut = new CheckInCheckOutOptions {
Enabled = false,
Timeout = 10,
AdditionalTime = 5,
};
SizeType = SizeType.Middle;
PaddingType = SizeType.Middle;
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Uygulama Ekleme Sayfası" },{ "en-US", "SupplyPage" },{ "ru-RU", "SupplyPage" },{ "az-Latn-AZ", "SupplyPage" },}){
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

BaseComponent default_supplypageComponent = new BaseComponent {
Id = "SupplyPage",
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
},
Properties = this,
ViewProperties = "",
};

AddToViewItems("default", default_supplypageComponent);

Divider7 = new Divider {
ControlId = "1108294c-6e90-45ed-7b5c-1c09e68c87e6",
Name = "Divider7",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Divider7" },}){
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

Controls.Add(Divider7);

BaseComponent default_divider7Component = new BaseComponent {
Id = "Divider7",
Type = "Divider",
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
Properties = Divider7,
ViewProperties = "",
};

AddToViewItems("default", default_divider7Component);

Properties1 = new DataGrid {
ControlId = "249a6dd0-ed0e-305e-ed8b-7a48112e1423",
Name = "Properties1",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Özellikler" },}){
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
VerticalAlign = VerticalAlign.Top,
MarkSettings = new MarkSettings {
Char = "*",
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
EntityPath = "E_SupplierIdentification_SupplyPage_PROPERTIES1",
ReadOnly = false,
DefaultReadOnly = false,
Required = false,
Indexable = false,
DisplayType = DataGridDisplayType.AutoGrow,
PreferredWidthType = DataGridColumnPreferredWidthType.Auto,
SaveMode = SaveMode.Form,
Columns = new DataGridColumnCollection {
new GridColumn() {
EditControl = 
new TextBox {
Value = "",
Text = "",
EntityPath = "ML.NewColumn1",
ReadOnly = false,
Required = false,
MaxLength = 50
},
DbType = new ColumnDbType() {
ColumnName = "NewColumn1",
Type = "string"
},
FormatType = new ColumnFormatType {
Type = "label",
Format = ""
},
DisableToExport = false,
Precision = 0,
UseThousandSeparator = false,
Align = HorizontalAlign.Left,
Caption = new Dictionary<string, string> {
{ "tr-TR", "Tanım" },
},
AllowHiding = true,
AllowNull = true,
HeaderFilterEnabled = false,
Style = new Dictionary<string, object> {
},
EditType = ColumnEditType.TextBox,
EditingEnabled = true,
ShowEditorAlways = false,
Filtering = new DataGridColumnFilteringOptions {
Enabled = false,
Operation = DataGridFilteringOperation.Contains,
Value = "",
},
Index = 0,
Name = "Definition1",
Sorting = new DataGridColumnSortingOptions {
Enabled = true,
Index = 0,
Order = DataGridSortingDirection.Asc,
},
SummaryTypes = new List<DataGridSummaryType> {
},
SummaryTypePrefixes = new List<DataGridColumnSummary> {
},
Width = "100",
WordWrapEnabled = false,
IsPrimaryKey = true,
IsGeneratedColumn = false,
Visible = true,
HidingPriority = null,
SourceType = GridColumnSourceType.Base64,
EnlargeOnClick = false,
ImageWidth = 100,
SizeUnit = GridColumnSizeUnit.Pixels,
ImageType = GridColumnImageType.SmallImage,
PreferredWidth = 0,
IconMatchers = new List<IconMatchers>{
},
MultiLanguageLoadOptions = new List<MultiLanguageLoadOptions>{
},
CheckUniqueValue = false,
CustomizeNullText = false,
NullText = new Dictionary<string, string> {
},
AlertType = AlertType.Warning,
AutoIncrement = false,
},
},
Rows = new DataGridRowCollection {

},
DataSource = new DataSource {
Name = "",
ValueMember = "",
DisplayMember = new List<string>{
},
DisplayFormat = "",
Culture = "",
CultureMember = "",
MultiLanguagePath = "",
RunAtServer = false,
Field = "",
Parameters = new List<DataSourceParameter>{
},
MultiLanguageLoadOptions = new List<MultiLanguageLoadOptions>{
},
ConnectionType = null,
DefaultValue = null,
UseClientCachedData = true,
EnableMultiLanguageDisplayMember = false,
DisplayMemberML = new Dictionary<string, DisplayMemberML> {
},
},
ColumnSettings = new DataGridColumnOptions {
Orderable = false,
Resizeable = false,
ShowColumnChooser = false,
},
DetailRow = new DataGridDetailRowOptions {
Enabled = false,
},
Editing = new DataGridEditingOptions {
Enabled = false,
ShowAddCommand = true,
ShowEditCommand = false,
ShowDeleteCommand = false,
Mode = DataGridEditingModeType.Row,
},
Filtering = new DataGridFilteringOptions {
Enabled = false,
ShowOperationChooser = false,
HeaderFilterEnabled = false,
},
Grouping = new DataGridGroupingOptions {
Enabled = false,
},
Paging = new DataGridPagingOptions {
Enabled = true,
CurrentPage = 1,
PageSize = 10,
PagingSizes = new List<int> {
10,
20,
30,
40,
},
},
Searching = new DataGridSearchingOptions {
Enabled = false,
},
Selection = new DataGridSelectionOptions {
Enabled = false,
Mode = DataGridSelectionMode.Single,
SelectAllMode = DataGridSelectAllMode.Page,
ShowCheckBoxesMode = DataGridShowCheckBoxMode.OnClick,
ShowSelectAll = false,
Type = DataGridSelectionType.Rowselect,
DisabledValueColumnName = "",
DisabledValueMatchers = new List<object>{
},},
Sorting = new DataGridSortingOptions {
Enabled = false,
AllSortingColumns = true,
Mode = DataGridSortingMode.None,
},
TreeView = new DataGridTreeViewOptions {
Enabled = false,
Id = "",
ParentId = "",
},
AlternateColor = new DataGridAlternateColorOptions {
Enabled = true,
Color = "rgba(33, 150, 243, 0.05)",
},
RowDragging = new DataGridRowDraggingOptions {
Enabled = false,
ShowDragIcons = false,
},
ToolbarActionButtons = new List<ExecuteActionButton> {
},
FillForm = null,
Height = null,
ExportToExcel = false,
GridBorder = true,
ColumnVerticalBorder = true,
VirtualScrolling = false,
HoverStateEnabled = false,
ShowClearAllButton = false,
ColumnAutoWidth = true,
SaveAction = false,
WordWrapEnabled = false,
ColumnHidingEnabled = false,
ColumnFixingEnabled = false,
CacheSettingsEnabled = false,
GridLines = DataGridLineType.Horizontal,
DataSourceType = DataSourceType.Dynamic,
HiddenRowColumnName = null,
HiddenRowValueMatchers = new DataGridHiddenRowValueOptions {
},
};

Controls.Add(Properties1);

BaseComponent default_properties1Component = new BaseComponent {
Id = "Properties1",
Type = "DataGrid",
ParentId = "Column2",
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
Properties = Properties1,
ViewProperties = "",
};

AddToViewItems("default", default_properties1Component);

Column4 = new Column {
ControlId = "b9217f22-4cac-4f61-b45c-9b5be7709de5",
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
ParentId = "Section3",
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
},
Properties = Column4,
ViewProperties = "",
};

AddToViewItems("default", default_column4Component);
Controls.Add(Column4);

Label2 = new Label {
ControlId = "49d8cb5f-4524-3799-ab16-4b4f3164b5be",
Name = "Label2",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Label2" },}){
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
Size = "12",
Color = "rgb(0, 0, 0)",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Bu anlaşma, 'Bimser Çözüm' (bundan sonra 'Hizmet Sağlayıcı' olarak anılacaktır) ile hizmet talep eden firma/kişi (bundan sonra 'Müşteri' olarak anılacaktır) arasında yapılmıştır." },{ "en-US", "Label2" },{ "ru-RU", "Label2" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Center,
};

Controls.Add(Label2);

BaseComponent default_label2Component = new BaseComponent {
Id = "Label2",
Type = "Label",
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
Properties = Label2,
ViewProperties = "",
};

AddToViewItems("default", default_label2Component);

Divider8 = new Divider {
ControlId = "8ea8ed8c-ce92-bf30-ca94-4115db6f67be",
Name = "Divider8",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = false,
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Divider8" },}){
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

Controls.Add(Divider8);

BaseComponent default_divider8Component = new BaseComponent {
Id = "Divider8",
Type = "Divider",
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
Properties = Divider8,
ViewProperties = "",
};

AddToViewItems("default", default_divider8Component);

Column5 = new Column {
ControlId = "594c7099-c36d-4a23-9766-f0d29eb4ea64",
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
ParentId = "Section4",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = "33%",
Visible = true,
ClientVisible = true,
Padding = "0px 10px 0px 10px",
},
},
Items = new List<string> {
"MajorValue",
},
Properties = Column5,
ViewProperties = "",
};

AddToViewItems("default", default_column5Component);
Controls.Add(Column5);

Label3 = new Label {
ControlId = "83c9333c-1fad-552f-72e0-69ddd351e77c",
Name = "Label3",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Label3" },}){
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
Size = "12",
Color = "rgb(0, 0, 0)",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "1. Hizmetin Kapsamı" },{ "en-US", "Label3" },{ "ru-RU", "Label3" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
};

Controls.Add(Label3);

BaseComponent default_label3Component = new BaseComponent {
Id = "Label3",
Type = "Label",
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
Properties = Label3,
ViewProperties = "",
};

AddToViewItems("default", default_label3Component);

        }

        // initialize user events
        public override void InitUserEvents()
        {
            





































































        }
    }
}