var toolsViewModel = {
    migrationStatus: ko.observable({
        SubjectsInDatabase: 0,
        SubjectsInFileSystem: 0
    }),

    updateMigrationStatus: function (e) {
        e.preventDefault();
        $.get('/api/Migrate').done(function (data) {
            this.migrationStatus(data);
        });
    }
};

$(document).ready(function () {
    ko.applyBindings(toolsViewModel);
});
