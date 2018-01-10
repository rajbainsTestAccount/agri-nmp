// https://www.npmjs.com/package/html-pdf
//var pdf = require('html-pdf');

module.exports = function (callback, rawdata, pdfOptions) {

const DEFAULT_PDF_OPTIONS = {
	format: 'letter',
	orientation: 'landscape', // portrait or landscape
}

	// https://www.npmjs.com/package/html-pdf
	var pdf = require('html-pdf');
	
	// export as PDF
    pdf.create(rawdata, pdfOptions).toBuffer(function(err, buffer){
		if (err)
		{
			callback (err, null);
		}
		else
		{					
			callback (null, buffer.toJSON());
		}
    });

    pdf = null;
};
