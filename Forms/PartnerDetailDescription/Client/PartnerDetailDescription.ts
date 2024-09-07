export default class PartnerDetailDescription extends Form.Designer {

	async PartnerDetailDescription_OnLoad(args: Controls.EventArgs.ILoadEventArgs) {
		if (this.imageDocuments.files.length > 0) {
			this.imageDelete.visible = true;
			this.imageAdd.visible = false;

			this.PartnerImage.visible = false;
			const result = await this.fetch.post("/PartnerDetailDescription/DownloadBase64Image",
				{
					Id: this.imageDocuments.files[0].id
				});
			this.PartnerImage.imageBase64 = result.data as string;
			this.PartnerImage.visible = true;
			await this.applyChanges();

			const previewImage = document.getElementById('PartnerImage').querySelector("img");
			const lightbox = document.getElementById('PartnerDetailLightbox');
			const lightboxImage = document.getElementById("PartnerDetailLightbox").querySelector("img");

			previewImage.addEventListener('dblclick', () => {
				if (this.IMAGEID.value > 0) {
					lightboxImage.src = previewImage.src;
					lightboxImage.removeAttribute("height");
					lightboxImage.removeAttribute("width");
					lightbox.style.display = 'flex';
				}
			});

			lightbox.addEventListener('click', () => {
				lightbox.style.display = 'none';
			});
		}
		else {
			this.imageDelete.visible = false;
			this.imageAdd.visible = true;
		}
	}

    fileType: any;
	async imageDocuments_OnAfterFileAdd(args: Controls.EventArgs.IRDFileAddEventArgs) {
        this.imageAdd.visible = false;
		this.imageDelete.visible = true;
		this.fileType = args.file.extension;

		this.PartnerImage.visible = true;
		const result = await this.fetch.post("/PartnerDetailDescription/DownloadBase64Image",
			{
				Id: args.file.id
			});
		this.PartnerImage.imageBase64 = result.data as string;
		this.IMAGEID.value = (Number)(args.file.id);
		await this.applyChanges();
	}

	async imageDelete_OnClick(args: Controls.EventArgs.IClickEventArgs) {
		const culture = this.__form.currentLanguage.culture;
		let title = "Warning";
		let message = "Picture will be deleted Are you sure?";
		if (culture === "tr-TR") {
			title = "Uyarı";
			message = "Resim Silinecek, Emin Misiniz?";
		}
		await this.showConfirm(title, message).then(() => {
			this.imageDocuments.files = [];
			this.imageAdd.visible = true;
			this.imageDelete.visible = false;
			this.PartnerImage.visible = true;
			this.PartnerImage.imageBase64 = "";
			this.IMAGEID.value = 0;
		});
	}

	async imageAdd_OnClick(args: Controls.EventArgs.IClickEventArgs) {
		const buttonCover = document.querySelector("#imageDocuments .bcIcon");
		//const newButton = buttonCover.childNodes('[title="Yeni Dosya"]');
		(buttonCover as any).click();
	}

}