/// <reference path="jquery-1.7.2-vsdoc.js" />
/// <reference path="jquery-1.7.2.js" />

$(document).ready(function () {
    // alert('jQuery is loaded and ready!');


    $('#go-get').click(function (e) {
        e.preventDefault();

        var data = $.trim($('#txtGet').val());
        if (data == '') {
            alert('no data!');
            return;
        }

        var dfd = $.get('/maps/httpget', {
            data: data
        });

        var $result = $('#result');

        $result.text('Loading...');

        dfd.done(function (result) {
            var response = 'Get Success!: ' + JSON.stringify(result);
            $result.html(response);
            console.log(response);
        });

        dfd.fail(function (xhr) {
            var response = 'Get Failed: ' + JSON.stringify(xhr);
            $result.html(response);
            console.log(response);
        });
    }); // Get request

    $('#go-post').click(function (e) {
        e.preventDefault();

        var data = $.trim($('#txtPost').val());
        if (data == '') {
            alert('no data!');
            return;
        }

        var $result = $('#result');

        $result.text('Loading...');

        var dfd = $.post('/maps', {
            Content: data
        });

        dfd.done(function (result) {
            var response = 'Post Success!: ' + JSON.stringify(result);
            $result.html(response);
            console.log(response);
        });

        dfd.fail(function (xhr) {
            var response = 'Post failed: ' + JSON.stringify(xhr);
            $result.html(response);
            console.log(response);
        });

    }); // Post request

});     // $(document).ready()