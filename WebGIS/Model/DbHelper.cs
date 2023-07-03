using Microsoft.EntityFrameworkCore;
using WebGIS.EfCore;

namespace WebGIS.Model
{
    public class DbHelper
    {
        private readonly EF_DataContext _context;

        public DbHelper(EF_DataContext context)
        {
            _context = context;
        }

        public List<AnoCesticeModel> GetAnoCestice()
        {
            List<AnoCesticeModel> response = new List<AnoCesticeModel>();
            var dataList = _context.AnoCestice.ToList();
            dataList.ForEach(row => response.Add(new AnoCesticeModel()
            {
                AnoCesticaId = row.AnoCesticaId,
                MaticniBrojKo = row.MaticniBrojKo,
                BrojCestice = row.BrojCestice,
                Rotacija = row.Rotacija,
                Coordinates = row.Coordinates
            }));
            return response;
        }
        public void SaveAnoCestice(List<AnoCesticeModel> featureModels)
        {
            try
            {
                foreach (AnoCesticeModel featureModel in featureModels)
                {
                    AnoCestice dbTable = _context.AnoCestice.FirstOrDefault(d => d.MaticniBrojKo.Equals(featureModel.MaticniBrojKo));

                    if (dbTable != null)
                    {
                        // PUT
                        dbTable.Rotacija = featureModel.Rotacija;
                        dbTable.AnoCesticaId = featureModel.AnoCesticaId;
                        dbTable.BrojCestice = featureModel.BrojCestice;
                        dbTable.Coordinates = featureModel.Coordinates;
                    }
                    else
                    {
                        // POST
                        AnoCestice newEntry = new AnoCestice();

                        newEntry.MaticniBrojKo = featureModel.MaticniBrojKo;
                        newEntry.Rotacija = featureModel.Rotacija;
                        newEntry.AnoCesticaId = featureModel.AnoCesticaId;
                        newEntry.BrojCestice = featureModel.BrojCestice;
                        newEntry.Coordinates = featureModel.Coordinates;

                        var conflictingEntity = _context.AnoCestice.Local.FirstOrDefault(e => e.MaticniBrojKo == newEntry.MaticniBrojKo);
                        if (conflictingEntity != null)
                        {
                            _context.Entry(conflictingEntity).State = EntityState.Detached;
                        }

                        _context.AnoCestice.Add(newEntry);
                    }
                }

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Exception innerException = ex.InnerException;
                Console.WriteLine("Inner Exception: " + innerException?.Message);
                Console.WriteLine("Inner Exception Stack Trace: " + innerException?.StackTrace);
            }
        }

        public void DeleteAnoCestice(int id)
        {
            var feature = _context.AnoCestice.Where(d => d.MaticniBrojKo.Equals(id)).FirstOrDefault();
            if (feature != null)
            {
                _context.AnoCestice.Remove(feature);
                _context.SaveChanges();
            }
        }

        public List<CesticeModel> GetCestice()
        {
            List<CesticeModel> response = new List<CesticeModel>();
            var dataList = _context.Cestice.ToList();
            dataList.ForEach(row => response.Add(new CesticeModel()
            {
                MaticniBrojKo = row.MaticniBrojKo,
                BrojCestice = row.BrojCestice,
                CesticaId = row.CesticaId,
                PovrsinaGraficka = row.PovrsinaGraficka,
                PovrsinaAtributna = row.PovrsinaAtributna,
                AdresaOpisna = row.AdresaOpisna,
                StatusKzKn = row.StatusKzKn,
                IzvornoMjerilo = row.IzvornoMjerilo,
                DetaljniList = row.DetaljniList,
                OznakaOkoline = row.OznakaOkoline,
                CesticaIzvorId = row.CesticaIzvorId,
                StatusCestice = row.StatusCestice,
                Coordinates = row.Coordinates
            }));
            return response;
        }
        public void SaveCestice(List<CesticeModel> featureModels)
        {
            try
            {
                foreach (CesticeModel featureModel in featureModels)
                {
                    Cestice dbTable = _context.Cestice.FirstOrDefault(d => d.MaticniBrojKo.Equals(featureModel.MaticniBrojKo));

                    if (dbTable != null)
                    {
                        // PUT
                        dbTable.CesticaId = featureModel.CesticaId;
                        dbTable.BrojCestice = featureModel.BrojCestice;
                        dbTable.PovrsinaAtributna = featureModel.PovrsinaAtributna;
                        dbTable.PovrsinaGraficka = featureModel.PovrsinaGraficka;
                        dbTable.AdresaOpisna = featureModel.AdresaOpisna;
                        dbTable.StatusCestice = featureModel.StatusCestice;
                        dbTable.StatusKzKn = featureModel.StatusKzKn;
                        dbTable.CesticaIzvorId = featureModel.CesticaIzvorId;
                        dbTable.OznakaOkoline = featureModel.OznakaOkoline;
                        dbTable.DetaljniList = featureModel.DetaljniList;
                        dbTable.IzvornoMjerilo = featureModel.IzvornoMjerilo;
                        dbTable.Coordinates = featureModel.Coordinates;
                    }
                    else
                    {
                        // POST
                        Cestice newEntry = new Cestice();

                        newEntry.MaticniBrojKo = featureModel.MaticniBrojKo;
                        newEntry.CesticaId = featureModel.CesticaId;
                        newEntry.BrojCestice = featureModel.BrojCestice;
                        newEntry.PovrsinaAtributna = featureModel.PovrsinaAtributna;
                        newEntry.PovrsinaGraficka = featureModel.PovrsinaGraficka;
                        newEntry.AdresaOpisna = featureModel.AdresaOpisna;
                        newEntry.StatusCestice = featureModel.StatusCestice;
                        newEntry.StatusKzKn = featureModel.StatusKzKn;
                        newEntry.CesticaIzvorId = featureModel.CesticaIzvorId;
                        newEntry.OznakaOkoline = featureModel.OznakaOkoline;
                        newEntry.DetaljniList = featureModel.DetaljniList;
                        newEntry.IzvornoMjerilo = featureModel.IzvornoMjerilo;
                        newEntry.Coordinates = featureModel.Coordinates;

                        _context.Cestice.Add(newEntry);
                    }
                }

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Exception innerException = ex.InnerException;
                Console.WriteLine("Inner Exception: " + innerException?.Message);
                Console.WriteLine("Inner Exception Stack Trace: " + innerException?.StackTrace);
            }
        }
        public void DeleteCestice(int id)
        {
            var feature = _context.Cestice.FirstOrDefault(d => d.MaticniBrojKo == id.ToString());

            if (feature != null)
            {
                _context.Cestice.Remove(feature);
                _context.SaveChanges();
            }
        }
         
        public List<NaciniUporabeModel> GetNaciniUporabe()
        {
            List<NaciniUporabeModel> response = new List<NaciniUporabeModel>();
            var dataList = _context.NaciniUporabe.ToList();
            dataList.ForEach(row => response.Add(new NaciniUporabeModel()
            {
                MaticniBrojKo = row.MaticniBrojKo,
                CesticaId = row.CesticaId,
                AdresaOpisna = row.AdresaOpisna,
                BrojCestice=row.BrojCestice,
                NacinUporabeId=row.NacinUporabeId,
                Povrsina=row.Povrsina,
                SifraVrsteUporabe=row.SifraVrsteUporabe,
                NazivVrsteUporabe=row.NazivVrsteUporabe,
                PosjedovniListBroj=row.PosjedovniListBroj,
                StatusNacinaUporabe=row.StatusNacinaUporabe,
                OznakaPravaGradjenja=row.OznakaPravaGradjenja,
                Coordinates = row.Coordinates

            }));
            return response;
        }
        public void SaveNaciniUporabe(List<NaciniUporabeModel> featureModels)
        {
            try
            {
                foreach (NaciniUporabeModel featureModel in featureModels)
                {
                    NaciniUporabe dbTable = _context.NaciniUporabe.FirstOrDefault(d => d.MaticniBrojKo.Equals(featureModel.MaticniBrojKo));

                    if (dbTable != null)
                    {
                        // PUT
                        dbTable.MaticniBrojKo = featureModel.MaticniBrojKo;
                        dbTable.Povrsina = featureModel.Povrsina;
                        dbTable.SifraVrsteUporabe = featureModel.SifraVrsteUporabe;
                        dbTable.BrojCestice = featureModel.BrojCestice;
                        dbTable.NazivVrsteUporabe = featureModel.NazivVrsteUporabe;
                        dbTable.AdresaOpisna = featureModel.AdresaOpisna;
                        dbTable.PosjedovniListBroj = featureModel.PosjedovniListBroj;
                        dbTable.CesticaId = featureModel.CesticaId;
                        dbTable.StatusNacinaUporabe = featureModel.StatusNacinaUporabe;
                        dbTable.OznakaPravaGradjenja = featureModel.OznakaPravaGradjenja;
                        dbTable.Coordinates = featureModel.Coordinates;
                    }
                    else
                    {
                        // POST
                        NaciniUporabe newEntry = new NaciniUporabe();

                        newEntry.NacinUporabeId = featureModel.NacinUporabeId;
                        newEntry.MaticniBrojKo = featureModel.MaticniBrojKo;
                        newEntry.Povrsina = featureModel.Povrsina;
                        newEntry.SifraVrsteUporabe = featureModel.SifraVrsteUporabe;
                        newEntry.BrojCestice = featureModel.BrojCestice;
                        newEntry.NazivVrsteUporabe = featureModel.NazivVrsteUporabe;
                        newEntry.AdresaOpisna = featureModel.AdresaOpisna;
                        newEntry.PosjedovniListBroj = featureModel.PosjedovniListBroj;
                        newEntry.CesticaId = featureModel.CesticaId;
                        newEntry.StatusNacinaUporabe = featureModel.StatusNacinaUporabe;
                        newEntry.OznakaPravaGradjenja = featureModel.OznakaPravaGradjenja;
                        newEntry.Coordinates = featureModel.Coordinates;

                        _context.NaciniUporabe.Add(newEntry);
                    }
                }

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Exception innerException = ex.InnerException;
                Console.WriteLine("Inner Exception: " + innerException?.Message);
                Console.WriteLine("Inner Exception Stack Trace: " + innerException?.StackTrace);
            }
        }
        public void DeleteNaciniUporabe(int id)
        {
            var feature = _context.NaciniUporabe.FirstOrDefault(d => d.NacinUporabeId == id.ToString());

            if (feature != null)
            {
                _context.NaciniUporabe.Remove(feature);
                _context.SaveChanges();
            }
        }
        
        public List<KatastarskeOpcineModel> GetKatastarskeOpcine()
        {
            List<KatastarskeOpcineModel> response = new List<KatastarskeOpcineModel>();
            var dataList = _context.KatastarskeOpcine.ToList();
            dataList.ForEach(row => response.Add(new KatastarskeOpcineModel()
            {
                MaticniBrojKo = row.MaticniBrojKo,
                StatusKzKn = row.StatusKzKn,
                IzvornoMjerilo = row.IzvornoMjerilo,
                KatastarskaOpcinaId=row.KatastarskaOpcinaId,
                VrstaKatastarskeOpcine=row.VrstaKatastarskeOpcine,
                Coordinates = row.Coordinates
            }));
            return response;
        }
        public void SaveKatastarskeOpcine(List<KatastarskeOpcineModel> featureModels)
        {
            try
            {
                foreach (KatastarskeOpcineModel featureModel in featureModels)
                {
                    KatastarskeOpcine dbTable = _context.KatastarskeOpcine.FirstOrDefault(d => d.MaticniBrojKo.Equals(featureModel.MaticniBrojKo));

                    if (dbTable != null)
                    {
                        // PUT
                        dbTable.NazivKo = featureModel.NazivKo;
                        dbTable.IzvornoMjerilo = featureModel.IzvornoMjerilo;
                        dbTable.StatusKzKn = featureModel.StatusKzKn;
                        dbTable.KatastarskaOpcinaId = featureModel.KatastarskaOpcinaId;
                        dbTable.VrstaKatastarskeOpcine = featureModel.VrstaKatastarskeOpcine;
                        dbTable.Coordinates = featureModel.Coordinates;
                    }
                    else
                    {
                        // POST
                        KatastarskeOpcine newEntry = new KatastarskeOpcine();

                        newEntry.MaticniBrojKo = featureModel.MaticniBrojKo;
                        newEntry.NazivKo = featureModel.NazivKo;
                        newEntry.IzvornoMjerilo = featureModel.IzvornoMjerilo;
                        newEntry.StatusKzKn = featureModel.StatusKzKn;
                        newEntry.KatastarskaOpcinaId = featureModel.KatastarskaOpcinaId;
                        newEntry.VrstaKatastarskeOpcine = featureModel.VrstaKatastarskeOpcine;
                        newEntry.Coordinates = featureModel.Coordinates;

                        _context.KatastarskeOpcine.Add(newEntry);
                    }
                }

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Exception innerException = ex.InnerException;
                Console.WriteLine("Inner Exception: " + innerException?.Message);
                Console.WriteLine("Inner Exception Stack Trace: " + innerException?.StackTrace);
            }
        }
        public void DeleteKatastarskeOpcine(int id)
        {
            var feature = _context.KatastarskeOpcine.FirstOrDefault(d => d.MaticniBrojKo == id.ToString());

            if (feature != null)
            {
                _context.KatastarskeOpcine.Remove(feature);
                _context.SaveChanges();
            }
        }

        public List<MedjeCesticaModel> GetMedjeCestica()
        {
            List<MedjeCesticaModel> response = new List<MedjeCesticaModel>();
            var dataList = _context.MedjeCestica.ToList();
            dataList.ForEach(row => response.Add(new MedjeCesticaModel()
            {
                MaticniBrojKo = row.MaticniBrojKo,
                MedjaCesticeId=row.MedjaCesticeId,
                Broj=row.Broj,
                Coordinates=row.Coordinates
            }));
            return response;
        }
        public void SaveMedjeCestica(List<MedjeCesticaModel> featureModels)
        {
            try
            {
                foreach (MedjeCesticaModel featureModel in featureModels)
                {
                    MedjeCestica dbTable = _context.MedjeCestica.FirstOrDefault(d => d.MaticniBrojKo.Equals(featureModel.MaticniBrojKo));

                    if (dbTable != null)
                    {
                        // PUT
                        dbTable.MedjaCesticeId = featureModel.MedjaCesticeId;
                        dbTable.Broj = featureModel.Broj;
                        dbTable.Coordinates = featureModel.Coordinates;
                    }
                    else
                    {
                        // POST
                        MedjeCestica newEntry = new MedjeCestica();

                        newEntry.MaticniBrojKo = featureModel.MaticniBrojKo;
                        newEntry.MedjaCesticeId = featureModel.MedjaCesticeId;
                        newEntry.Broj = featureModel.Broj;
                        newEntry.Coordinates = featureModel.Coordinates;

                        _context.MedjeCestica.Add(newEntry);
                    }
                }

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Exception innerException = ex.InnerException;
                Console.WriteLine("Inner Exception: " + innerException?.Message);
                Console.WriteLine("Inner Exception Stack Trace: " + innerException?.StackTrace);
            }
        }
        public void DeleteMedjeCestica(int id)
        {
            var feature = _context.MedjeCestica.FirstOrDefault(d => d.MaticniBrojKo == id.ToString());

            if (feature != null)
            {
                _context.MedjeCestica.Remove(feature);
                _context.SaveChanges();
            }
        }

        public List<IdentifikacijeModel> GetIdentifikacije()
        {
            List<IdentifikacijeModel> response = new List<IdentifikacijeModel>();
            var dataList = _context.Identifikacije.ToList();
            dataList.ForEach(row => response.Add(new IdentifikacijeModel()
            {
                MaticniBrojKo = row.MaticniBrojKo,
                BrojCestice = row.BrojCestice,
                CesticaId = row.CesticaId,
                ZkCesticaId= row.ZkCesticaId,
                BrojZkCestice=row.BrojZkCestice,
                PodbrojZkCestice=row.PodbrojZkCestice,
                GlavnaKnjigaId=row.GlavnaKnjigaId,
                OznakaVezeCestice=row.OznakaVezeCestice,
                OznakaVezeZkCestice=row.OznakaVezeZkCestice,
                Verificirano=row.Verificirano,
            }));
            return response;
        }
        public void SaveIdentifikacije(List<IdentifikacijeModel> featureModels)
        {
            try
            {
                foreach (IdentifikacijeModel featureModel in featureModels)
                {
                    Identifikacije dbTable = _context.Identifikacije.FirstOrDefault(d => d.MaticniBrojKo.Equals(featureModel.MaticniBrojKo));

                    if (dbTable != null)
                    {
                        // PUT
                        dbTable.Verificirano = featureModel.Verificirano;
                        dbTable.ZkCesticaId = featureModel.ZkCesticaId;
                        dbTable.BrojZkCestice = featureModel.BrojZkCestice;
                        dbTable.PodbrojZkCestice = featureModel.PodbrojZkCestice;
                        dbTable.GlavnaKnjigaId = featureModel.GlavnaKnjigaId;
                        dbTable.OznakaVezeCestice = featureModel.OznakaVezeCestice;
                        dbTable.OznakaVezeZkCestice = featureModel.OznakaVezeZkCestice;
                        dbTable.BrojCestice = featureModel.BrojCestice;
                        dbTable.CesticaId = featureModel.CesticaId;
                        dbTable.Coordinates = featureModel.Coordinates;
                    }
                    else
                    {
                        // POST
                        Identifikacije newEntry = new Identifikacije();

                        newEntry.MaticniBrojKo = featureModel.MaticniBrojKo;
                        newEntry.Verificirano = featureModel.Verificirano;
                        newEntry.ZkCesticaId = featureModel.ZkCesticaId;
                        newEntry.BrojZkCestice = featureModel.BrojZkCestice;
                        newEntry.PodbrojZkCestice = featureModel.PodbrojZkCestice;
                        newEntry.GlavnaKnjigaId = featureModel.GlavnaKnjigaId;
                        newEntry.OznakaVezeCestice = featureModel.OznakaVezeCestice;
                        newEntry.OznakaVezeZkCestice = featureModel.OznakaVezeZkCestice;
                        newEntry.BrojCestice = featureModel.BrojCestice;
                        newEntry.CesticaId = featureModel.CesticaId;
                        newEntry.Coordinates = featureModel.Coordinates;

                        _context.Identifikacije.Add(newEntry);
                    }
                }

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Exception innerException = ex.InnerException;
                Console.WriteLine("Inner Exception: " + innerException?.Message);
                Console.WriteLine("Inner Exception Stack Trace: " + innerException?.StackTrace);
            }
        }
        public void DeleteIdentifikacije(int id)
        {
            var feature = _context.Identifikacije.FirstOrDefault(d => d.MaticniBrojKo == id.ToString());

            if (feature != null)
            {
                _context.Identifikacije.Remove(feature);
                _context.SaveChanges();
            }
        }

        public List<CesticeZgradeModel> GetCesticeZgrade()
        {
            List<CesticeZgradeModel> response = new List<CesticeZgradeModel>();
            var dataList = _context.CesticeZgrade.ToList();
            dataList.ForEach(row => response.Add(new CesticeZgradeModel()
            {
                CesticaId = row.CesticaId,
                ZgradaId=row.ZgradaId
                
            }));
            return response;
        }
        public void SaveCesticeZgrade(List<CesticeZgradeModel> featureModels)
        {
            try
            {
                foreach (CesticeZgradeModel featureModel in featureModels)
                {
                    CesticeZgrade dbTable = _context.CesticeZgrade.FirstOrDefault(d => d.ZgradaId.Equals(featureModel.ZgradaId));

                    if (dbTable != null)
                    {
                        // PUT
                        dbTable.CesticaId = featureModel.CesticaId;
                        dbTable.ZgradaId = featureModel.ZgradaId;
                    }
                    else
                    {
                        // POST
                        CesticeZgrade newEntry = new CesticeZgrade();

                        newEntry.CesticaId = featureModel.CesticaId;
                        newEntry.ZgradaId = featureModel.ZgradaId;
                        _context.CesticeZgrade.Add(newEntry);
                    }
                }

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Exception innerException = ex.InnerException;
                Console.WriteLine("Inner Exception: " + innerException?.Message);
                Console.WriteLine("Inner Exception Stack Trace: " + innerException?.StackTrace);
            }
        }
        public void DeleteCesticeZgrade(int id)
        {
            var feature = _context.CesticeZgrade.FirstOrDefault(d => d.ZgradaId == id.ToString());

            if (feature != null)
            {
                _context.CesticeZgrade.Remove(feature);
                _context.SaveChanges();
            }
        }
        
    }
}

