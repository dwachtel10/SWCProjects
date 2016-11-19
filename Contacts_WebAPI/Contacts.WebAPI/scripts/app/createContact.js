$(document)
    .ready(function() {
        //show modal
        $('#btnShowAddContact')
            .on('click',
                function() {
                    $('#addContactModal').modal('show');
                });
        //save event, send data to server
        $('#btnSaveContact')
            .on('click',
                function () {
                    //create a contact object
                    var contact = new {};
                    contact.Name = $('#name').val();
                    contact.PhoneNumber = $('#phonenumber').val();

                    $.post(uri, contact)
                        .done(function() {
                            loadContacts();
                            $('#addContactModal').modal('hide');
                        })
                        .fail(function(jqXhr, status, err) {
                            alert(status + " - " + err);
                        });
                });

        //clears modal upon being hidden
        $('#addContactModal')
            .on('hidden.bs.modal',
                function() {
                    $('name').val('');
                    $('#phonenumber').val('');
                });

        // $('#')
    });