using Domain;
using Domain.Cipher;
using Presentation.Views;
using Services;

namespace Presentation.Presenters
{
    public class EditNotePresenter : BasePresenter<IEditNoteView>
    {
        private readonly INoteService noteService;
        private readonly IEncryptionService encryptionService;
        Note? note;
        public EditNotePresenter(IEditNoteView view, INoteService noteService, IEncryptionService encryptionService) : base(view)
        {
            this.noteService = noteService;
            this.encryptionService = encryptionService;
        }

        public void SetNoteId(Guid id)
        {
            note = noteService.FindById(id);
            
            if (note != null)
            {
                string decryptedPassword = encryptionService.Decrypt(note.Password);
                View.PopulateNoteData(note, decryptedPassword);
            }        }
    }
}