namespace Solid;

public class ModelForm : IForm
{
    private int _id { get; set; }
    private int _old { get; set; }
    private string _fio { get; set; }

    public ModelForm(int _id, int _old, string _fio)
    {
        this._id = _id;
        this._old = _old;
        this._fio = _fio;
    }
}