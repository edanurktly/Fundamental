using MDIFormlar.Entites;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDIFormlar.DbContect
{
    public class Db_context
    {
        //hashet listesi ozel bir listedir.
        // unique yapıya sahiptir. Aynı kayıttan ikinci kere almaz
        public static ICollection<Urun> Urunler = new HashSet<Urun>();

    }
}
