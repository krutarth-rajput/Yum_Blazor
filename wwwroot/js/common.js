function showDeleteConfirmationModal() {
    bootstrap.Modal.getOrCreateInstance(document.getElementById('deleteConfirmation')).show();
}

function hideDeleteConfirmationModal() {
    bootstrap.Modal.getOrCreateInstance(document.getElementById('deleteConfirmation')).hide();
}