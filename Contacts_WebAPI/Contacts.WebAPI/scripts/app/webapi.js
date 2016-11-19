var uri = '/api/contacts/';

$(document)
    .ready(function() {
        loadContacts();
    });

function loadContacts() {
    //chungus
    //Send a Get request to the WebAPI controller
    $.getJSON(uri)
        .done(function(data) {
            //data is some kind of object array
            //alert(data);

            $('#contacts tbody tr').remove();

            $.each(data,
                function (index, contact) {
                    $(createRow(contact)).appendTo($('#contacts tbody'));

                });
        });
};

function createRow(contact) {
    return '<tr><td>' +
        contact.ContactID +
        '</td><td>' +
        contact.Name +
        '</td><td>' +
        contact.PhoneNumber +
        '</td></tr>';
};