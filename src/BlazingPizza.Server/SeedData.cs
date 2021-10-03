using System;

namespace BlazingPizza.Server
{
    public static class SeedData
    {
        public static void Initialize(PizzaStoreContext db)
        {
           var projects = new Project[]
            {
                new Project()
                {
                    Name = "АРТ ПРОСТРАНСТВО «SODA»",
                    DescriptionLite = "СРЕДИ СОЛИСТОВ И МАЛЫХ ФОРМ",
                    Description = @"АРТ ПРОСТРАНСТВО «SODA» - творческий конкурс среди солистов, дуэтов, трио, квартетов, малых форм (до 9 человек).
                    Этот Проект уникален тем, что уделяет особое внимание самой сложной исполнительской форме в искусстве - сольному исполнению.
                    ПРОЕКТ проводится в формате просмотров, с соблюдением санитарно-эпидемиологических  требований, обеспечивающих предупреждение возникновения и распространения короновирусной инфекции.",
                    StartDateTime = DateTime.Now,
                    EndDatetime =  DateTime.Now.AddDays(3),
                    ImageUrl = "img/pizzas/2021/soda.jpg",
                },
                new Project()
                {
                    Id = 2,
                    Name = "«НОВЫЕ ЛЮДИ»",
                    DescriptionLite = "МЕЖДУНАРОДНЫЙ ТАНЦЕВАЛЬНЫЙ КОНГРЕСС",
                    Description = @"МЕЖДУНАРОДНЫЙ ТАНЦЕВАЛЬНЫЙ КОНГРЕСС проводится среди хореографических коллективов и отдельных исполнителей, как профессиональных, так и любительских, из разных регионов России, стран ближнего и дальнего зарубежья, представляющих хореографию различных стилей и направлений. 
	Обладатель гран-при получает главный приз - грант DРУГОГО FОРМАТА «Постановка номера конкурсного уровня с балетмейстером».",
                    ImageUrl = "img/pizzas/2021/noviludi.jpg",
                    StartDateTime = DateTime.Now.AddDays(2),
                    EndDatetime =  DateTime.Now.AddDays(3),
                },
                new Project()
                {
                    Id = 3,
                    Name = "«ROZETKA»",
                    DescriptionLite = "VI МЕЖДУНАРОДНЫЙ ФЕСТИВАЛЬ СОВРЕМЕННОГО ХОРЕОГРАФИЧЕСКОГО ИСКУССТВА",
                    Description = @"Международный фестиваль современного хореографического искусства «ROZETKA» 
                    ФЕСТИВАЛЬ ПРОВОДИТСЯ ЕЖЕГОДНО в городе Барнауле Алтайского края - один раз в год, среди хореографических коллективов и отдельных исполнителей из разных регионов России, стран ближнего и дальнего зарубежья. 
                    Принимают участие коллективы как профессиональные, так и любительские (количество участников в коллективе не ограничено).",
                    StartDateTime = DateTime.Now.AddDays(1),
                    EndDatetime =  DateTime.Now.AddDays(2),
                    ImageUrl = "img/pizzas/2022/rozetka.jpg",
                },
            };

           var genres = new Genre[]
           {
               new Genre() { Id = 1, Name = "Жанр 1" },
               new Genre() { Id = 2, Name = "Жанр 2" },
               new Genre() { Id = 3, Name = "Жанр 3" },
           };

           var nominations = new Nomination[]
           {
               new Nomination() { Id = 1, Name = "Номинация 1" },
               new Nomination() { Id = 2, Name = "Номинация 2" },
               new Nomination() { Id = 3, Name = "Номинация 3" },
           };
           
           db.Genres.AddRange(genres);
           db.Nominations.AddRange(nominations);
            db.Projects.AddRange(projects);
            db.SaveChanges();
        }
    }
}
