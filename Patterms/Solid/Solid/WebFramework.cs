namespace Solid;

public class WebFramework
{
    public void Save(IForm form)
    {
        PSQL db = new PSQL();
        db.Save(form);
    }
}