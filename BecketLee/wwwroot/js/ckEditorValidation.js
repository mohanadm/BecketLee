// ckEditorValidation 

$(document).ready(function () {
    $('#editEventForm').validate({
        ignore: [],
        rules: {
            EventHtml: {
                required: function() {
                    CKEDITOR.instances.EventHtml.updateElement();
                },
                minlength: 10
            }
        },
        messages: {
            EventHtml: {
                required: "There must be content for the event."
            }
        }
    });

    $('#editPartnerBioForm').validate({
        ignore: [],
        rules: {
            BiographyHtml : {
                required: function () {
                    CKEDITOR.instances.BiographyHtml.updateElement();
                },
                minlength: 10
            }
        },
        messages: {
            BiographyHtml: {
                required: "There must be content for the partner biography."
            }
        }
    });

    
});