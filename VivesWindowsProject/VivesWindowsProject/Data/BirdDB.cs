 using System;
using System.Collections.Generic;
using System.Linq;
using VivesWindowsProject.Model;

namespace VivesWindowsProject.Data
{
    public class BirdDB
    {
        // Properties
        private static List<Bird> _birds = new List<Bird>();


        // Constructors
        static BirdDB()
        {
            _birds.Add(new Bird("Black-shouldered kite", "Accipitridae", "35-38 cm", "The black-shouldered kite (Elanus axillaris) or Australian black-shouldered kite is a small raptor found in open habitat throughout Australia and resembles similar species found in Africa, Eurasia and North America, which have in the past also been named as black-shouldered kites. Measuring 35–38 cm (14–15 in) in length with a wingspan of 80–95 cm (31–37 in), the adult black-shouldered kite is a small and graceful, predominantly pale grey and white, raptor with black shoulders and red eyes. Their primary call is a clear whistle, uttered in flight and while hovering.", "White", "https://upload.wikimedia.org/wikipedia/commons/thumb/8/88/Elanus_axillaris_-Royal_Botanic_Gardens%2C_Cranbourne%2C_Melbourne%2C_Victoria%2C_Australia-8.jpg/220px-Elanus_axillaris_-Royal_Botanic_Gardens%2C_Cranbourne%2C_Melbourne%2C_Victoria%2C_Australia-8.jpg", 0));
            _birds.Add(new Bird("Madagascar harrier-hawk", "Accipitridae", "Unknown", "Polyboroides radiatus has a large black and white striped tail, black and white barring on its underside, a grey back and long bare yellow legs. There is a bare pink or yellow skin patch around the eye, and bare white flesh around the mouth. The primaries, which are only visible with the wing outstretched, are striped white and light brown (see photo).", "Grey", "https://upload.wikimedia.org/wikipedia/commons/thumb/b/be/Madagascar_harrier-hawk_polyboroides_radiatus.jpg/280px-Madagascar_harrier-hawk_polyboroides_radiatus.jpg", 0));
            _birds.Add(new Bird("Madagascar cuckoo-hawk", "Accipitridae", "Unknown", "The Madagascan cuckoo-hawk (Aviceda madagascariensis), also known as the Madagascar baza or the Madagascan cuckoo falcon, is a species of bird of prey in the Accipitridae family. It is endemic to Madagascar. Its natural habitats are subtropical or tropical moist lowland forests and subtropical or tropical moist montane forests.", "Brown", "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5f/Aviceda_madagascariensis_1868.jpg/220px-Aviceda_madagascariensis_1868.jpg", 0));
            _birds.Add(new Bird("Red-billed tropicbird", "Phaethontiformes", "48 cm", "The adult is a slender, mainly white bird, 48 cm long, excluding the central tail feathers which double the total length, and a one-metre wingspan. The long wings have black markings on the flight feathers. There is black through the eye. The bill is red. Sexes are similar, although males average longer tails. Juveniles lack the tail streamers, are greyer-backed, and have a yellow bill. P. a. indicus has a reduced black eye stripe, and a more orange-tinted bill.Its wind are made up of very large feather coat. They feed on fish and squid, but are poor swimmers.", "White", "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4b/Red-billed_tropicbird_%28Phaethon_aethereus_mesonauta%29_with_chick.jpg/220px-Red-billed_tropicbird_%28Phaethon_aethereus_mesonauta%29_with_chick.jpg", 0));
            _birds.Add(new Bird("Oriental stork", "Ciconiiformes", "100-129 cm", "The Oriental stork (Ciconia boyciana) is a large, white bird with black wing feathers in the stork family Ciconiidae. It is closely related to and resembles the European white stork, of which it was formerly often treated as a subspecies. It is typically larger than the white stork, at 100–129 cm (40–51 in) long, 110–150 cm (43–59 in) tall, a weight of 2.8–5.9 kg (6.2–13.0 lb) and a wingspan of 2.22 m (7.3 ft).[2][3] Unlike its more widespread cousin, the Oriental stork has red skin around its eye, with a whitish iris and black bill. Both sexes are similar. The female is slightly smaller than male. The young are white with orange bills.", "White", "https://upload.wikimedia.org/wikipedia/commons/thumb/d/db/Oriental_Stork_2_marugame_kagawa.jpg/220px-Oriental_Stork_2_marugame_kagawa.jpg", 0));
        }

        // Methods
        public static List<Bird> GetBirds() { return _birds; }

        public static bool Add(Bird bird)
        {
            if (bird == null)
            {
                throw new ArgumentNullException("bird");
            }

            if (!_birds.Contains(bird))
            {
                _birds.Add(bird);
                return true;
            }

            return false;
        }

        public static void Update(Bird bird)
        {
            if (bird == null)
            {
                throw new ArgumentNullException("bird");
            }

            Bird updateBird = _birds.Find(p => (p.Name == bird.Name));

            if (updateBird != null)
            {
                updateBird.Name = bird.Name;
                updateBird.BirdType = bird.BirdType;
                updateBird.Length = bird.Length;
                updateBird.Description = bird.Description;
                updateBird.BaseColor = bird.BaseColor;
                updateBird.ImageUrl = bird.ImageUrl;
            }
        }

        public static void Delete(Bird bird)
        {
            if (_birds.Contains(bird))
            {
                _birds.Remove(bird);
            }
        }

        //public static bool Contains(Bird bird)
        //{
        //    if (bird == null)
        //    {
        //        throw new ArgumentNullException("bird");
        //    }

        //    return (FindByName(bird.Name) != null);
        //}

        //public static Bird FindById(long id)
        //{
        //    return _birds.Find(p => (p.Id == id));
        //}

        //public static Bird FindByName(string name)
        //{
        //    return _birds.Find(p => (p.Name.Equals(name)));
        //}
    }
}
