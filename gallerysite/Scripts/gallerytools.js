var toolsViewModel = {
    migrationStatus: ko.observable({
        SubjectsInDatabase: 0,
        SubjectsInFileSystem: 0
    })
};

$(document).ready(function () {
    ko.applyBindings(toolsViewModel);

    $('#migrationStatusButton').click(function (e) {
        e.preventDefault();
        $.get('/api/Migrate'
          ).done(function(data) {
            toolsViewModel.migrationStatus(data);
        });
    });
});
