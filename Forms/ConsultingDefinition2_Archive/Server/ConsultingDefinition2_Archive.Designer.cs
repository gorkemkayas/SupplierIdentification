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

    public partial class ConsultingDefinition2_Archive : Form<E_SupplierIdentification_ConsultingDefinition2_ArchiveEntity> {

        // properties
        Section Row1 { get; set; }
Column Column1 { get; set; }
DataGrid ConsultingDefinition2_Archive_Grid { get; set; }
TextBox FILTERPARAMS { get; set; }
ContextMenu ctxConsultingDefinition { get; set; }


        // constructor
        public ConsultingDefinition2_Archive(FormHttpParameters httpParameters, IContext context)
 : base(httpParameters, context)
        {
        }

        // initialize members
        public override void InitMembers()
        {
            
ClientVisible = true;
ProjectName = "SupplierIdentification";
ProjectId = "561223b1-10f4-4f7e-88c7-35378b4dd997";
EntityPath = "";
ActiveView = "default";
Version = 19;
ReadOnly = false;
DefaultReadOnly = false;
Text = new Dictionary<string, string> {
{ "tr-TR", "ConsultingDefinition2_Archive" },
{ "en-US", "ConsultingDefinition2_Archive" },
{ "ru-RU", "ConsultingDefinition2_Archive" },
{ "az-Latn-AZ", "ConsultingDefinition2_Archive" },
};
Name = "ConsultingDefinition2_Archive";
FormId = "09fe6bd4-989f-48d4-889f-52dd8f800930";
FormType = FormType.Standard;
ServerEvents = new List<EventItem> {
};
ClientEvents = new List<EventItem> {
new EventItem {
Name = "OnToolbarButtonClicked",
MethodName = "ConsultingDefinition2_Archive_OnToolbarButtonClicked",
Async = null
},
new EventItem {
Name = "OnLoad",
MethodName = "ConsultingDefinition2_Archive_OnLoad",
Async = null
},
new EventItem {
Name = "OnMessageReceived",
MethodName = "ConsultingDefinition2_Archive_OnMessageReceived",
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
Key = "New",
Name = "New",
Icon = "add",
Enabled = true,
DefaultEnabled = true,
Validate = false,
Caption = new Dictionary<string, string> {
{ "tr-TR", "Yeni" },
},
View = "",
IsServerPrint = false,
},
new ToolbarButton {
Key = "listPassive",
Name = "listPassive",
Icon = "switch-off",
Enabled = true,
DefaultEnabled = true,
Validate = false,
Caption = new Dictionary<string, string> {
{ "tr-TR", "Pasifleri Dahil Et" },
},
View = "",
IsServerPrint = false,
},
new ToolbarButton {
Key = "closePassive",
Name = "closePassive",
Icon = "switch-on",
Enabled = false,
DefaultEnabled = false,
Validate = false,
Caption = new Dictionary<string, string> {
{ "tr-TR", "Pasifleri Dahil Et" },
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Danışmanlık Listesi" },{ "en-US", "ConsultingDefinition2_Archive" },{ "ru-RU", "ConsultingDefinition2_Archive" },{ "az-Latn-AZ", "ConsultingDefinition2_Archive" },}){
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

BaseComponent default_consultingdefinition2_archiveComponent = new BaseComponent {
Id = "ConsultingDefinition2_Archive",
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
"Row1",
},
Properties = this,
ViewProperties = "",
};

AddToViewItems("default", default_consultingdefinition2_archiveComponent);

Row1 = new Section {
ControlId = "eb8600a0-27c7-4dd7-9d37-8dd370ac3005",
Name = "Row1",
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


BaseComponent default_row1Component = new BaseComponent {
Id = "Row1",
Type = "Section",
ParentId = "ConsultingDefinition2_Archive",
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
Properties = Row1,
ViewProperties = "",
};

AddToViewItems("default", default_row1Component);
Controls.Add(Row1);

Column1 = new Column {
ControlId = "93ad6421-60ee-4bde-9c67-d1bb7c5dbe95",
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
ParentId = "Row1",
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
"ConsultingDefinition2_Archive_Grid",
"FILTERPARAMS",
},
Properties = Column1,
ViewProperties = "",
};

AddToViewItems("default", default_column1Component);
Controls.Add(Column1);

ConsultingDefinition2_Archive_Grid = new DataGrid {
ControlId = "0ffca89e-271d-481b-9f34-8ee98ad395c1",
Name = "ConsultingDefinition2_Archive_Grid",
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
ContextMenuKey = "ctxConsultingDefinition",
ContextMenuTarget = ContextMenuTarget.Row,
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "ConsultingDefinition2_Archive_Grid" },{ "en-US", "ConsultingDefinition2_Archive_Grid" },{ "ru-RU", "ConsultingDefinition2_Archive_Grid" },{ "az-Latn-AZ", "ConsultingDefinition2_Archive_Grid" },}){
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
EntityPath = "",
ReadOnly = false,
DefaultReadOnly = false,
Required = false,
Indexable = false,
DisplayType = DataGridDisplayType.AutoGrow,
PreferredWidthType = DataGridColumnPreferredWidthType.Auto,
SaveMode = SaveMode.Form,
Columns = new DataGridColumnCollection {
new DataGridActionButtonColumn {
ActionButtonProps = new ExecuteActionButton {
TypeName = ExecuteActionType.OpenFormArgs,
Icon = "search",
Title = new Dictionary<string, string> {
{ "tr-TR", "View" },
{ "en-US", "View" },
{ "ru-RU", "View" },
{ "az-Latn-AZ", "View" },
},
Text = new Dictionary<string, string> {
{ "tr-TR", "View" },
{ "en-US", "View" },
{ "ru-RU", "View" },
{ "az-Latn-AZ", "View" },
},
Args = new OpenFormArgs {
DocumentId = "[DOCUMENTID]",
View = "",
Editable = false,
IsSaveAsForm = false,
Size = 1,
ShowOn = ActionButtonShowOnTypes.Panel,
CloseCurrentPanel = false,
Parameters = new List<ExecutionArgsParameterItem> {
},
},
Name = "View_action_button",
Visible = true,
},
EditControl = 
null,DbType = new ColumnDbType() {
ColumnName = "View",
Type = "none"
},
FormatType = new ColumnFormatType {
Type = "actionButton",
Format = ""
},
DisableToExport = false,
Precision = 0,
UseThousandSeparator = false,
Align = HorizontalAlign.Left,
Caption = new Dictionary<string, string> {
{ "tr-TR", "View" },
{ "en-US", "View" },
{ "ru-RU", "View" },
{ "az-Latn-AZ", "View" },
},
AllowHiding = true,
AllowNull = true,
HeaderFilterEnabled = false,
Style = new Dictionary<string, object> {
},
EditType = ColumnEditType.ActionButton,
EditingEnabled = true,
ShowEditorAlways = false,
Filtering = new DataGridColumnFilteringOptions {
Enabled = false,
Operation = DataGridFilteringOperation.Contains,
Value = "",
},
Index = 0,
Name = "View",
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
IsPrimaryKey = false,
IsGeneratedColumn = true,
Visible = false,
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
new GridColumn() {
EditControl = 
new NumberBox {
Visible = true,
EntityPath = "DOCUMENTID",
ReadOnly = false,
Required = false,
},
DbType = new ColumnDbType() {
ColumnName = "DOCUMENTID",
Type = "decimal"
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
{ "tr-TR", "DOCUMENTID" },
{ "en-US", "DOCUMENTID" },
{ "ru-RU", "DOCUMENTID" },
{ "az-Latn-AZ", "DOCUMENTID" },
},
AllowHiding = true,
AllowNull = true,
HeaderFilterEnabled = false,
Style = new Dictionary<string, object> {
},
EditType = ColumnEditType.NumberBox,
EditingEnabled = false,
ShowEditorAlways = false,
Filtering = new DataGridColumnFilteringOptions {
Enabled = false,
Operation = DataGridFilteringOperation.Contains,
Value = "",
},
Index = 1,
Name = "DOCUMENTID",
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
IsGeneratedColumn = true,
Visible = false,
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
new GridColumn() {
EditControl = 
new TextBox {
Value = "",
Text = "",
EntityPath = "ML.CONSULTANCYNAME",
ReadOnly = false,
Required = false,
MaxLength = 500
},
DbType = new ColumnDbType() {
ColumnName = "CONSULTANCYNAME",
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
{ "tr-TR", "Çözüm Adı" },
{ "en-US", "CONSULTANCYNAME" },
{ "ru-RU", "CONSULTANCYNAME" },
{ "az-Latn-AZ", "CONSULTANCYNAME" },
},
AllowHiding = true,
AllowNull = true,
HeaderFilterEnabled = false,
Style = new Dictionary<string, object> {
},
EditType = ColumnEditType.TextBox,
EditingEnabled = false,
ShowEditorAlways = false,
Filtering = new DataGridColumnFilteringOptions {
Enabled = false,
Operation = DataGridFilteringOperation.Contains,
Value = "",
},
Index = 2,
Name = "CONSULTANCYNAME",
Sorting = new DataGridColumnSortingOptions {
Enabled = true,
Index = 0,
Order = DataGridSortingDirection.Asc,
},
SummaryTypes = new List<DataGridSummaryType> {
},
SummaryTypePrefixes = new List<DataGridColumnSummary> {
},
Width = "15%",
WordWrapEnabled = false,
IsPrimaryKey = false,
IsGeneratedColumn = true,
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
new GridColumn() {
EditControl = 
new TextBox {
Value = "",
Text = "",
EntityPath = "ML.SYSTEMNAME1",
ReadOnly = false,
Required = false,
MaxLength = 500
},
DbType = new ColumnDbType() {
ColumnName = "SYSTEMNAME1",
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
{ "tr-TR", "Sistem Adı" },
{ "en-US", "SYSTEMNAME1" },
{ "ru-RU", "SYSTEMNAME1" },
{ "az-Latn-AZ", "SYSTEMNAME1" },
},
AllowHiding = true,
AllowNull = true,
HeaderFilterEnabled = false,
Style = new Dictionary<string, object> {
},
EditType = ColumnEditType.TextBox,
EditingEnabled = false,
ShowEditorAlways = false,
Filtering = new DataGridColumnFilteringOptions {
Enabled = false,
Operation = DataGridFilteringOperation.Contains,
Value = "",
},
Index = 3,
Name = "SYSTEMNAME1",
Sorting = new DataGridColumnSortingOptions {
Enabled = true,
Index = 0,
Order = DataGridSortingDirection.Asc,
},
SummaryTypes = new List<DataGridSummaryType> {
},
SummaryTypePrefixes = new List<DataGridColumnSummary> {
},
Width = "10%",
WordWrapEnabled = false,
IsPrimaryKey = false,
IsGeneratedColumn = true,
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
new GridColumn() {
EditControl = 
new TextBox {
Value = "",
Text = "",
EntityPath = "ML.CATEGORY1",
ReadOnly = false,
Required = false,
MaxLength = 500
},
DbType = new ColumnDbType() {
ColumnName = "CATEGORY1",
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
{ "tr-TR", "Kategori" },
{ "en-US", "CATEGORY1" },
{ "ru-RU", "CATEGORY1" },
{ "az-Latn-AZ", "CATEGORY1" },
},
AllowHiding = true,
AllowNull = true,
HeaderFilterEnabled = false,
Style = new Dictionary<string, object> {
},
EditType = ColumnEditType.TextBox,
EditingEnabled = false,
ShowEditorAlways = false,
Filtering = new DataGridColumnFilteringOptions {
Enabled = false,
Operation = DataGridFilteringOperation.Contains,
Value = "",
},
Index = 4,
Name = "CATEGORY1",
Sorting = new DataGridColumnSortingOptions {
Enabled = true,
Index = 0,
Order = DataGridSortingDirection.Asc,
},
SummaryTypes = new List<DataGridSummaryType> {
},
SummaryTypePrefixes = new List<DataGridColumnSummary> {
},
Width = "10%",
WordWrapEnabled = false,
IsPrimaryKey = false,
IsGeneratedColumn = true,
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
new GridColumn() {
EditControl = 
new TextBox {
Value = "",
Text = "",
EntityPath = "ML.SECTOR1",
ReadOnly = false,
Required = false,
MaxLength = 500
},
DbType = new ColumnDbType() {
ColumnName = "SECTOR1",
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
{ "tr-TR", "Sektör" },
{ "en-US", "SECTOR1" },
{ "ru-RU", "SECTOR1" },
{ "az-Latn-AZ", "SECTOR1" },
},
AllowHiding = true,
AllowNull = true,
HeaderFilterEnabled = false,
Style = new Dictionary<string, object> {
},
EditType = ColumnEditType.TextBox,
EditingEnabled = false,
ShowEditorAlways = false,
Filtering = new DataGridColumnFilteringOptions {
Enabled = false,
Operation = DataGridFilteringOperation.Contains,
Value = "",
},
Index = 5,
Name = "SECTOR1",
Sorting = new DataGridColumnSortingOptions {
Enabled = true,
Index = 0,
Order = DataGridSortingDirection.Asc,
},
SummaryTypes = new List<DataGridSummaryType> {
},
SummaryTypePrefixes = new List<DataGridColumnSummary> {
},
Width = "10%",
WordWrapEnabled = false,
IsPrimaryKey = false,
IsGeneratedColumn = true,
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
new GridColumn() {
EditControl = 
new TextBox {
Value = "",
Text = "",
EntityPath = "ML.SESSIONTYPE",
ReadOnly = false,
Required = false,
MaxLength = 500
},
DbType = new ColumnDbType() {
ColumnName = "SESSIONTYPE",
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
{ "tr-TR", "Oturum Türü" },
{ "en-US", "SESSIONTYPE" },
{ "ru-RU", "SESSIONTYPE" },
{ "az-Latn-AZ", "SESSIONTYPE" },
},
AllowHiding = true,
AllowNull = true,
HeaderFilterEnabled = false,
Style = new Dictionary<string, object> {
},
EditType = ColumnEditType.TextBox,
EditingEnabled = false,
ShowEditorAlways = false,
Filtering = new DataGridColumnFilteringOptions {
Enabled = false,
Operation = DataGridFilteringOperation.Contains,
Value = "",
},
Index = 6,
Name = "SESSIONTYPE",
Sorting = new DataGridColumnSortingOptions {
Enabled = true,
Index = 0,
Order = DataGridSortingDirection.Asc,
},
SummaryTypes = new List<DataGridSummaryType> {
},
SummaryTypePrefixes = new List<DataGridColumnSummary> {
},
Width = "10%",
WordWrapEnabled = false,
IsPrimaryKey = false,
IsGeneratedColumn = true,
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
new GridColumn() {
EditControl = 
new TextBox {
Value = "",
Text = "",
EntityPath = "ML.CONSULTINGFEES",
ReadOnly = false,
Required = false,
MaxLength = 500
},
DbType = new ColumnDbType() {
ColumnName = "CONSULTINGFEES",
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
{ "tr-TR", "Çözüm Ücreti" },
{ "en-US", "CONSULTINGFEES" },
{ "ru-RU", "CONSULTINGFEES" },
{ "az-Latn-AZ", "CONSULTINGFEES" },
},
AllowHiding = true,
AllowNull = true,
HeaderFilterEnabled = false,
Style = new Dictionary<string, object> {
},
EditType = ColumnEditType.TextBox,
EditingEnabled = false,
ShowEditorAlways = false,
Filtering = new DataGridColumnFilteringOptions {
Enabled = false,
Operation = DataGridFilteringOperation.Contains,
Value = "",
},
Index = 7,
Name = "CONSULTINGFEES",
Sorting = new DataGridColumnSortingOptions {
Enabled = true,
Index = 0,
Order = DataGridSortingDirection.Asc,
},
SummaryTypes = new List<DataGridSummaryType> {
},
SummaryTypePrefixes = new List<DataGridColumnSummary> {
},
Width = "10%",
WordWrapEnabled = false,
IsPrimaryKey = false,
IsGeneratedColumn = true,
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
new GridColumn() {
EditControl = 
new TextBox {
Value = "",
Text = "",
EntityPath = "ML.CURRENCYTYPE",
ReadOnly = false,
Required = false,
MaxLength = 500
},
DbType = new ColumnDbType() {
ColumnName = "CURRENCYTYPE",
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
{ "tr-TR", "Para Birimi" },
{ "en-US", "CURRENCYTYPE" },
{ "ru-RU", "CURRENCYTYPE" },
{ "az-Latn-AZ", "CURRENCYTYPE" },
},
AllowHiding = true,
AllowNull = true,
HeaderFilterEnabled = false,
Style = new Dictionary<string, object> {
},
EditType = ColumnEditType.TextBox,
EditingEnabled = false,
ShowEditorAlways = false,
Filtering = new DataGridColumnFilteringOptions {
Enabled = false,
Operation = DataGridFilteringOperation.Contains,
Value = "",
},
Index = 8,
Name = "CURRENCYTYPE",
Sorting = new DataGridColumnSortingOptions {
Enabled = true,
Index = 0,
Order = DataGridSortingDirection.Asc,
},
SummaryTypes = new List<DataGridSummaryType> {
},
SummaryTypePrefixes = new List<DataGridColumnSummary> {
},
Width = "10%",
WordWrapEnabled = false,
IsPrimaryKey = false,
IsGeneratedColumn = true,
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
new GridColumn() {
EditControl = 
new TextBox {
Value = "",
Text = "",
EntityPath = "ML.FEESTATUS",
ReadOnly = false,
Required = false,
MaxLength = 500
},
DbType = new ColumnDbType() {
ColumnName = "FEESTATUS",
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
{ "tr-TR", "Ücret Durumu" },
{ "en-US", "FEESTATUS" },
{ "ru-RU", "FEESTATUS" },
{ "az-Latn-AZ", "FEESTATUS" },
},
AllowHiding = true,
AllowNull = true,
HeaderFilterEnabled = false,
Style = new Dictionary<string, object> {
},
EditType = ColumnEditType.TextBox,
EditingEnabled = false,
ShowEditorAlways = false,
Filtering = new DataGridColumnFilteringOptions {
Enabled = false,
Operation = DataGridFilteringOperation.Contains,
Value = "",
},
Index = 9,
Name = "FEESTATUS",
Sorting = new DataGridColumnSortingOptions {
Enabled = true,
Index = 0,
Order = DataGridSortingDirection.Asc,
},
SummaryTypes = new List<DataGridSummaryType> {
},
SummaryTypePrefixes = new List<DataGridColumnSummary> {
},
Width = "10%",
WordWrapEnabled = false,
IsPrimaryKey = false,
IsGeneratedColumn = true,
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
new GridColumn() {
EditControl = 
new CheckBox {
Visible = true,
EntityPath = "ACTIVITY",
ReadOnly = false,
Required = false,
},
DbType = new ColumnDbType() {
ColumnName = "ACTIVITY",
Type = "boolean"
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
{ "tr-TR", "Aktiflik" },
{ "en-US", "ACTIVITY" },
{ "ru-RU", "ACTIVITY" },
{ "az-Latn-AZ", "ACTIVITY" },
},
AllowHiding = true,
AllowNull = true,
HeaderFilterEnabled = false,
Style = new Dictionary<string, object> {
},
EditType = ColumnEditType.CheckBox,
EditingEnabled = false,
ShowEditorAlways = false,
Filtering = new DataGridColumnFilteringOptions {
Enabled = false,
Operation = DataGridFilteringOperation.Contains,
Value = "",
},
Index = 10,
Name = "ACTIVITY",
Sorting = new DataGridColumnSortingOptions {
Enabled = true,
Index = 0,
Order = DataGridSortingDirection.Asc,
},
SummaryTypes = new List<DataGridSummaryType> {
},
SummaryTypePrefixes = new List<DataGridColumnSummary> {
},
Width = "10%",
WordWrapEnabled = false,
IsPrimaryKey = false,
IsGeneratedColumn = true,
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
Name = "ConsultingDefinition2_Archive_DataSource",
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
new DataSourceParameter {
Name = "PARAMS",
IsRequired = true,
Length = 255,
ValueType = ParameterValueType.String,
ValueModifier = ValueModifierType.FieldSelection,
Field = "FILTERPARAMS.value",
Value = "0",
Children = new List<DataSourceParameter>{
},
},
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
ShowAddCommand = false,
ShowEditCommand = false,
ShowDeleteCommand = false,
Mode = DataGridEditingModeType.Row,
},
Filtering = new DataGridFilteringOptions {
Enabled = true,
ShowOperationChooser = false,
HeaderFilterEnabled = true,
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
Enabled = true,
},
Selection = new DataGridSelectionOptions {
Enabled = true,
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
Mode = DataGridSortingMode.Single,
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

Controls.Add(ConsultingDefinition2_Archive_Grid);

BaseComponent default_consultingdefinition2_archive_gridComponent = new BaseComponent {
Id = "ConsultingDefinition2_Archive_Grid",
Type = "DataGrid",
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
Properties = ConsultingDefinition2_Archive_Grid,
ViewProperties = "",
};

AddToViewItems("default", default_consultingdefinition2_archive_gridComponent);

FILTERPARAMS = new TextBox {
ControlId = "ecc9127a-b438-a530-fa4b-6945660cdc50",
Name = "FILTERPARAMS",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "FILTERPARAMS" },}){
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
EntityPath = "ML.FILTERPARAMS",
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
MultiLanguageText = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
SizeType = null,
};

Controls.Add(FILTERPARAMS);

BaseComponent default_filterparamsComponent = new BaseComponent {
Id = "FILTERPARAMS",
Type = "TextBox",
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
Properties = FILTERPARAMS,
ViewProperties = "",
};

AddToViewItems("default", default_filterparamsComponent);

ctxConsultingDefinition = new ContextMenu {
ControlId = "fd5ba510-ac48-b4e9-271e-e8ec5f4261a8",
Name = "ctxConsultingDefinition",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
new EventItem {
Name = "OnItemClick",
MethodName = "ctxConsultingDefinition_OnItemClick",
Async = null
},
new EventItem {
Name = "OnShowing",
MethodName = "ctxConsultingDefinition_OnShowing",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "ContextMenu1" },}){
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
DataSource = new DataSource {
},
DataSourceType = DataSourceType.Static,
ParentKey = "",
ItemsExpr = "",
Items = new List<ExecuteActionButton> {
new ExecuteActionButton {
TypeName = ExecuteActionType.ContextItemArgs,
Icon = "form-viewer-2",
Title = new Dictionary<string, string> {
{ "tr-TR", "Görüntüle" },
},
Text = new Dictionary<string, string> {
{ "tr-TR", "Görüntüle" },
},
Args = new ContextItemArgs {
Children = new List<ExecuteActionButton>{
},
Size = 1,
ShowOn = ActionButtonShowOnTypes.Panel,
CloseCurrentPanel = false,
Parameters = new List<ExecutionArgsParameterItem> {
},
},
Name = "Copy",
Visible = true,
},
new ExecuteActionButton {
TypeName = ExecuteActionType.ContextItemArgs,
Icon = "edit",
Title = new Dictionary<string, string> {
{ "tr-TR", "Düzenle" },
},
Text = new Dictionary<string, string> {
{ "tr-TR", "Düzenle" },
},
Args = new ContextItemArgs {
Children = new List<ExecuteActionButton>{
},
Size = 1,
ShowOn = ActionButtonShowOnTypes.Panel,
CloseCurrentPanel = false,
Parameters = new List<ExecutionArgsParameterItem> {
},
},
Name = "Edit",
Visible = true,
},
new ExecuteActionButton {
TypeName = ExecuteActionType.ContextItemArgs,
Icon = "switch-on",
Title = new Dictionary<string, string> {
{ "tr-TR", "Aktif Et" },
},
Text = new Dictionary<string, string> {
{ "tr-TR", "Aktif Et" },
},
Args = new ContextItemArgs {
Children = new List<ExecuteActionButton>{
},
Size = 1,
ShowOn = ActionButtonShowOnTypes.Panel,
CloseCurrentPanel = false,
Parameters = new List<ExecutionArgsParameterItem> {
},
},
Name = "MakeActive",
Visible = true,
},
new ExecuteActionButton {
TypeName = ExecuteActionType.ContextItemArgs,
Icon = "switch-off",
Title = new Dictionary<string, string> {
{ "tr-TR", "Pasif Et" },
},
Text = new Dictionary<string, string> {
{ "tr-TR", "Pasif Et" },
},
Args = new ContextItemArgs {
Children = new List<ExecuteActionButton>{
},
Size = 1,
ShowOn = ActionButtonShowOnTypes.Panel,
CloseCurrentPanel = false,
Parameters = new List<ExecutionArgsParameterItem> {
},
},
Name = "MakePassive",
Visible = true,
},
new ExecuteActionButton {
TypeName = ExecuteActionType.ContextItemArgs,
Icon = "delete",
Title = new Dictionary<string, string> {
{ "tr-TR", "Sil" },
},
Text = new Dictionary<string, string> {
{ "tr-TR", "Sil" },
},
Args = new ContextItemArgs {
Children = new List<ExecuteActionButton>{
},
Size = 1,
ShowOn = ActionButtonShowOnTypes.Panel,
CloseCurrentPanel = false,
Parameters = new List<ExecutionArgsParameterItem> {
},
},
Name = "Delete",
Visible = true,
},
},
};

Controls.Add(ctxConsultingDefinition);

BaseComponent default_ctxconsultingdefinitionComponent = new BaseComponent {
Id = "ctxConsultingDefinition",
Type = "ContextMenu",
ParentId = "ConsultingDefinition2_Archive",
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
Properties = ctxConsultingDefinition,
ViewProperties = "",
};

AddToViewGhostItems("default", default_ctxconsultingdefinitionComponent);

        }

        // initialize user events
        public override void InitUserEvents()
        {
            




        }
    }
}