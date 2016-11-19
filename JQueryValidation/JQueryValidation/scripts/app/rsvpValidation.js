$(document)
    .ready(function() {
        $('#rsvpForm')
            .validate({
                rules:
                {
                    Name: {
                        required: true
                    },
                    Email: {
                        required: true,
                        email: true
                    },
                    Phone: {
                        required: true,
                        phoneUS: true

                    },
                    FavoriteGame: {
                        required: true
                    },
                    WillAttend: {
                        required: true
                    }
                }
            });

    })