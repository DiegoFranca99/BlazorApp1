namespace BlazorApp1.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductVariant>()
                .HasKey(p => new { p.ProductId, p.ProductTypeId });

            modelBuilder.Entity<ProductType>().HasData(
                    new ProductType { Id = 1, Name = "Default" },
                    new ProductType { Id = 2, Name = "Paperback" },
                    new ProductType { Id = 3, Name = "E-Book" },
                    new ProductType { Id = 4, Name = "Audiobook" },
                    new ProductType { Id = 5, Name = "Stream" },
                    new ProductType { Id = 6, Name = "Blu-ray" },
                    new ProductType { Id = 7, Name = "VHS" },
                    new ProductType { Id = 8, Name = "PC" },
                    new ProductType { Id = 9, Name = "PlayStation" },
                    new ProductType { Id = 10, Name = "Xbox" }
                );

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Books",
                    Url = "books"
                },
                new Category
                {
                    Id = 2,
                    Name = "Movies",
                    Url = "movies"
                },
                new Category
                {
                    Id = 3,
                    Name = "Video Games",
                    Url = "video-games"
                });

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Titulo do Livro 11",
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    ImageUrl = "data:image/jpeg;base64,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",
                    CategoryId = 1
                },
                new Product
                {
                    Id = 2,
                    Title = "Titulo do Livro 2",
                    Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).",
                    ImageUrl = "data:image/jpeg;base64,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",
                    CategoryId = 1
                },
                new Product
                {
                    Id = 3,
                    Title = "Titulo do Livro 3",
                    Description = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, Lorem ipsum dolor sit amet.., comes from a line in section 1.10.32.",
                    ImageUrl = "data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAoHCBYWFRgWFhUZGBgYGBgYGBgcGhwaGhgaGBgZGRgaGhgcIS4lHB4rIRgYJjgmKy8xNTU1GiQ7QDs0Py40NTEBDAwMEA8QHxISHzYrJSw0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NP/AABEIALcBEwMBIgACEQEDEQH/xAAbAAACAwEBAQAAAAAAAAAAAAADBAACBQEGB//EADgQAAEDAgUCBAQFBAEFAQAAAAEAAhEDBBIhMUFRBWETcYGRIjKhsQYUwdHwFUJS4WJTcpKiwhb/xAAZAQADAQEBAAAAAAAAAAAAAAAAAQMCBAX/xAAoEQACAgICAgICAQUBAAAAAAAAAQIRAyESMRNBBFEiYTIUcYGRoUL/2gAMAwEAAhEDEQA/APUW9TEeytWcGpWi8sbog3N75T+i3xt6J8qQGu1rpPmkbTp7HjMumc84mExTrZnKZ+64yg8OBn4ZzCsm0qsi0m7otZ03MfgEwJM5nyErQvbHGGh2gIOX2V6TQ0zytJsETspyk7tFFFVQpa0mUwcAAnMgaT5Lly7IHlcrOyP0VC8FoI1GyX7C/Q/YNgdlLk5+aA2tlK7RuAXZpV7N36G6zQGrMfVIbByn6ea1WuxZ7INzGkBKLoGrPN134TIExkfVZl9dEvZhEO2nT1W7fMAB/wCRzj9F5m/MExsZHK7MNSZxZm4o9Ey4xsa0j4oE+aMKWLKBMLN/DzjGN055AduVvmBnGyjP8ZUi8HyimxSytC14dkTwdOclssZ2hI0jmCdk2bkcqUm2ykUkhTqT4HZYtKsahw6wddvKVp31RrwWmCOFa3psbpAVItRj+zErcu9ClTEyAUa0vScuO6zutXzQcysZvWI01mfNVjhlKN0RlnjGVWe1NUHVZd/XAyDsys1nXgdQQfRDZcF0uPKI4ZRewlnjJUmFLZcBv9E/QfnDc4ErCu7ozOJE6dduJkvA101hUljbjZOOaKlR6BpB+bbj9Ulc1sRwhuQ3K0KFZmCQZyWV/Uqb3FuINKjGLbei0ppJW+zj2bc7a7arjbF7tBGeuyZs3NDvmBn6rVbcNATlJx6FGMZdmH+Rqt311glHq9KY9uYgxqP1Tl1dgJa/ug1hcNQE05toTUEmefuHmi4gHUIdPrTmnQFZt1cOeSSd/byQMHdd6wxa/Ls4PLJP8XSPQ/1x/wDi33XF5zD3UT8EPo15p/Z9Me8PGSVpUJnFHElL9IrFrGl3zHVaDmzJOS8pri6PTUuSsUrFrNFRt83IkxOaBe1g52Bjs4zOWUryHUKL2OLZc5ux8gr48Kl2yE8zj0fRKdcOiFbxyzMLxPS+ovpCXtcWbZaf6XrbcOqUw+IkSBv6rGTDwe+jcM3Ja7JUugTlvsiMqQvMP6sxjycyZgjSI+6t/wDocRhrCSdAt+CXpE1nXtnqnVABql212tdJM8rFbdPLSXNwjbcykbm8e3X4g7Icg+iUcLehS+Qkes/rrR8DYnWDwuV+sMDSSYyXz1z3Nd8UtPeZWiKb3kYmnDEGDBiMtdFX+lit2S/q5dUMV+ul53GZhZz76TJCNf2DG/I4l3+Os+Szn0HggFpBOgIhdMIQrRCUpN7Zu2H4hwCCyQO6br/iyRDWH1IXkiCu4kP4+Nu2jSzZEqTN6t+JKp+WGj3S1TrVVxBxkRxp7LLhVzW1hgukjLnJ9s0ndVqHMvKJ/Wq3+f0Cy4XQn44fSM8pfbHavUXuEGD3hK41WFzAVpRS6Mt32Wxq7blw0JQsKrCdJhoI+sTqZVqVZwPwmCgFqsKTtYRSHSGfzzxkHmOxgIBeTmhukLmJCSXQ+xindPaZDiEyOqVYjGVm4vJdaUnCL7QbQ87qNQ6vJ9lStfPcMJcY4CWk8KrpSUI/QbZ3EpiVJXJWwotKirKiB0aFl1BzHtLi6GzkeTlmtW5/EOLJod2nILzTn8klcL1zvFGTtoopySpGmLp4mo4kbATmT+ypRrOccT3Q3TaZP81WZUqTr90HEtcEFNnubAMBAdhgQQCZz5K1bnq7GtgPaMuQvmWIq2ZUpfGUnbZSM3FUjQvq7CSWySSSSd5Q7K5DHh0TG0pVrDwreGeF0cVVEqSNu867jaGhuHnNJ0b/AA5xiO0mY8gs7wip4RSUIpUkDSbts03dQxOD3NxOGnCFXv3PMk/skxSXcgmopGaRo2fUCx2LKYiVet1AvdJdHCysY4XQ/slxV2Jx1RqXNduBoBl26SaATnkEsXlSTymlQKFD1ZwOekQBz6oAcgK7Gnv9Ew40guJdBVYPB+imfBQKgrEUJdoPCKMXCDEkXIVHBQzwFQk8fRAkiLkKCeP57qZ8INHCAuZcK8KpQNMquSug9l3D2TGVJXCrEHj7LkHj7IGiq4oWu2XMDuyDX+TqimB3ZRAf5OmkVU0yncIVXOHKwYU2JeGVzwDwnA4K3omPyNCfhFQUz3KewSqeCeSgFkANpnj+e6KGd0QUu5VxTHM+qLMSnYE0jyqOoO5TzWdlw0vP3RZhZKEPAPKhoHn6J7wB3XDSCLNeUTa2P7vougngpk01wM7IsfNMG1srvhogYrYOyLMOYLw1MCOGdlYMRYuYtgXcKZ8Nd8NFmeYuGroajFqrCLDkDhcLUXCpCLCwGFTCjhqsKaLHyFsKmFOCj2V/A8kWZ8iEPDXfDThDR/cFAG8osfkYl4a4aafwBcNMIsXkM/AphTpYFCwIs15BHConMIURY+ZnttnnZx9P3R2WR3Huf2C2mUcpOQ5OQSFS5An7qSlfQvNKXSBNtgOArhreUB91sUEAOOQWrNcZPcmaAY1R1Nvn7oNOiBq76o7Gt2z9SUWTeumymAcD2V4A0H0V2tHCuG9kWYcwGI8KY+xR2sVnBrRLoHbf2RyFyXVCvi8Nd7QiU2l2oI9v0UqdRaMmj15SpvnHt5I2yijJ+qHn0IEk/wA9UDE3h30/dA8Sdc1ZpTEotdhw5o2JUxTsR7LgBXQEGdHFMRG5+kK4arBqVi5IF43cfRQOndMOtzuFMLQJLmjtqfZHJBa9IXLeSuhiJ4rdj911tZuzSfT90WFv6B4FMCMCf8fqrEmNAEWZti3hq7WIoJ5C4X/8kWFtlmu7IHUGmAQZH29Fd1cATMpSpVLtdELuzUIu7FA8o1GrGokfVR5AQ5HC0dPa6NBtVp3jzyV5HIWWGk6I7GO5SolLGl7HHNQnBdpk7kIgalZPoBgUTGFRFj5AeoX7TkHEj6eiyTUJyGaapWk5mSm6dpGywtHQpQhpGcKTnLQtLUAZtB80yyjCctrTFvEZ+aJNJbJSyuWoi7KDRoAPRGp0Tor1qzW/KwDuczProsy86k/TFHll9llWzEY8nVlK78Lo34RW3CzGmTKu5xVKLPEuhutdwMkg+oTqc1So6EDGSmVhiSWi6ct6Tig0aW61LapsQgzlnS0UbQRm0UbCrsYdglZxubYHw10MTTKHOSlxdUmNyzfwM/fhZb+ginLoEKDuCPPJNCoxjZe5ogaD5j2WNcdSe7KcI4CUAJMn31Q4t9lo462w9e6L3bhpOTZ+6eo9O3SdK3G60rd7m5AwE3daFOaWkdfbhuyEX4dk/Up5TBd3Bj91l1wlF2SrZPHKG5/f6oURuquOa3RRRXoNCs2kSr2xBTQak2TlJp0I1qcDJJ1JHZbdxQy/mSzKlJOLspjn9ijDKZp0JQjSATVF8JspOWvxLMoRorGnyERlwNwEU12b5ev7rDbIXJsQfTPmqCth3ITNxeUY+Z3pCyrm6B+UEDumtl4QlLtD35wcrqx8S6tUingiegpnkJqnTJ+USqMtS7Qo1vbubJLnADUiR9lCUl6ORR5P9BHW4HzuDewzPsEP80xmhcfWPoFj39y1riRME5A5lZVW+LtJCaja2y8MDe10b971gOyDGHuRJWC7E93bgaBEpUspdkUai4BbUUuiyqF1tnW2ZA3QnujZaDq8iElUpElaRiMm3+QqQXI1KiAr4MIRKTpQblN1roNSYnGUkKnTTdNqTOLJMbsqTYMwTsJz9jkh3r3tEvGEHQCIPsr03Ju8YH0naFwGp1AGZhRk6krHjqSaPK3V44/C2ddAu0unvOZhvnr7BBuKBaZnv5LVsbskfEAe+hVnrotJ8YLhQs2wG7vojMtW8rRZTa7t5hR3TXHSD5FZ5pdkFKchMMjdEYFS5tHszIySv5ojkLSpq0JwkzVbWdEajiFx9JrtQR5ZrObed1Y1iRqlx+gUZLs5fWoaJD2/9v8Ad7BZHjpioM8zPmpToAnIStpNLZ1xpLYW0qnXRa9GuDkW+yTpWobm4+iYqXQboAPr91mSs5ZtSf4mm9jGtxE+kgSsK+rN2EfVBub6d1m16xOhRGFdstDE5NOqLGuuYid0sHcqeKtnXw+gj6h/yPuqAE7rhdK613f6JGqpHcK5KO3PRdFIpmeX2BwqJ4WaiRPyxNWlUIT9vXedASPKQuUKAnJs+iN1EuwDMMjYmJHkM1yyabo5IRdNozLrpNMkud8JJJOJ2XoJWNcikw/CJPMD9UzcVgSQDPflZtducq0U0jpxJt/k3/YHWrOOmQQ/EKq4orHZGUzqpJdFqdeN07b1tFmBqYpPI3yWic4JrRsOAISpZDskajU+Gd1GUiSlZyJ8bsboHJNtCUpNhEurvCABvukzmlHlKkPMpEq5cG6vaPMhY4uZ1KTvXA5wCQsuDfspjx7pjXUrilmGuDjuG6D1QLSfRKWdIOPZblvSAC0tIrlcYLigtAkBadmZSTGKz+pU6XzvAOmEZn2GihmkqJ/HjKUtKwvWq7owAQMiTzwsCtmF6hj2XDBk4a4XQdlldQ6U8DFgcW8gaefHqlgywrj7OnNhyRlbWjy7qmaPQqE7pepauk7DadVwHDrPvmusq4xa0aQpj+4phlZjRlmsJtcTz5rrrhFk3gb02ale+Kz61yXJN1WVRz0FoYFEYNQcoZeqNaSmaNFBR1Eo1pRWsCeo9Pce3mmW9OA1M/RFnPLPFezKwBW8MJ+tQjRLEGc0WJZOXRe3op6lbwqW5CeYJWWzlyTlZWFEx4KixyRGmW6h1B1OWyGjsvL3XUC92RMfdCubkvOaUcOElFJaPTx4fcuxn8yeF0VcWyXaeyniHyWrKcF6QZzJ/ZUc1VFYqYScwnY0muzolWpNJcAhgFda6CixtG7bNG5AT9KmOQV51lc75rUsa/KDzs2JpXZqYAszq1PQjVPl8rM6jUMwhEsCfNGcK5Bgpm3YHmFwhhAnXsutpRm0z9Cmdsqa1pm3a2YEaD1CfbSYNXheco3LhlCbbcHfJYlFv2cUoST3s3GtZ/kPqg3b+HR5GPqsv84Bug3HVABsfRZUNjipvUVX9gd5UdObnRvDv1WbVuCcpMeZQrm+Lko6qqJUejjxSr8uxwVQN4QK1VsZSTyUq56qE7LRxpbCGouF/dDJV6dOUWUpIs3NMULUuRrW2nZbdC3y0jsg5c2dR0hG3sOVsW9o1o0zTVr05zogepyWmOikD4ngehKlLNGLps45RzZlaWjIcFRwWz/Sh/1B6iP1Vj0U/wCQWPPBeycfi5X0v+nmq1AnTVJPY4HML1FzYtZ872tnSSAgusZBIIcOxB+y1HPF+yqhlgto85TqEHNaNvXB81S8sADlkkhLSq2mjMlGa12b7arVxZjA4hRZ4x+zHjkYDgf8ShAHgobXOGeaK0OOcOjsUHrcaO4XcLmA8IzKL3CQ04fJVptc055DyTM2RtKRJVm5Tmr1O2iGWQmZu+y1tBdBRnWkGQJCFTyzCbp3HKETnKSdxBAAI9FHa5jtR7qwdTYOfqghKd6p2N0IiSs27rznG6HX6iXZNGSTrOKaQ8WFp2wrXI7HpBs7K2I7pl5QsfNcDcIbrzgJFz0FzykEcKGa1yTv7JV7yoRlqqFJl4xS6KOKrKvCsGIKXQKFM+EwxiuKKKE5pC7Gdlo2lsShUqUlbNiyEI5s+Wlo0ek9ODnNbzuvU1rZjAHYcmjOBI8yNVl9FrNBIP8APIr0BcY+H9/suH5E5cq9GfixjODk9u/9Ge3q7ANR6Bw/+Vd/VmATM9oP7JG/okvktidSAR7yFgXby1xBmPqlDFGYTz5YPiad9fBxDmDAc5gxPpygUOs1RkJ9WiPcLJ/MK9K5E/Fouzxx41VnNymm5e/0bnUroPtnvqNzD2tYQNzOL0IEe3AXm6HVm0z8AIB1Ej4s9+8T/Jn0VvdMjCw5HUEgg+YKO3oDH5vpsbOwB/QheXlxuMm1o9fBmjKCjLb9mR4gqtxMJcNx/cw8Ecd0tUoFeos+lUaJxMYJIiSHOP8A7OyRn4DrRB+hXRj+S0qaOXL8Vcrg6X0zybaZ5+yi9L+Vp/8ASP8A5H91Fbzr6I+CX2Y/SujNLCHtk6ZrasumMY3AAITPyo1Llc0skpez1o4or0InpTYyAbnqFn3nRA4EanZepAlArMhKOWSfYSwxa6Pn9XpDtMWe/wDpZlW3c0wQvoVa1DjMLyvWLZzXuyJGsrtx5eTpnBlxyx7XRjtYN1bG0JZ7zKGZVjPG+xipdcBKueXHMrT6JZeJUAc2WDX10W1ffhT4S5hM6wdPJYlOMXTZSMK6R5QOhTEjXdo+m7C9pH290rMbLaY6GZQ3OhC8UobnlDYKLC4kMuVWgk5J5/S3BodOZEx/tFjdR7YlKIwDdBV2hCZposXLuaoERjUCeiNBR2NKvb0JK0G0QBmg555UtCNBplaFB8KmEDZQOhBCb5GrQrEQQSF6Tpd8CIJz3XjqVZNMq8FSyY1NUyMJyxStHuq7SW5Hbb/a89eWIdkWkHmIWh0e7JEEytG5Ej/S89OWKVHptRzw5I8HddPIORWfWpEL192xu4WXXtmu4Xfjy8ls8+VwlV2jz7KxC3On/iJ7AGn4gNj+hSFz08jT+eqzKrC08KkoxkqeysJJu4umfQrbrVJ4EuDDw7T30TJcHfK5p8iPdfMmXRatOx6thOv1XPL4sf8Ayy0suRLas9m62qfyFFmM6zkM1FLxZPoz58f7Ni5ORPC7ZPkSooo+j1vY14kKrqkqKLJoGlL61DxnuootxbsxJJrZgXH4eaCSDlnlsvLXtMtcW8FRRd2KTadnFOKi1R6j8DNHxkjOQPRe4DBCii5M/wDNnVg/iYvW+mNqMIImdDuO6+bXFqWOLScxKiiv8Ztp2RzaloC9qCWqKLpMIcs7OYO+wWvcy1uFRRC9HNkdvZg1KcGVeg0uICiifstb4m/b9Fxtn5TtvKC/oxa7PMZrqikpuyUm1EL4OEQIVBmYK4oqnIddQOoKGQVFEAmyA9kzbVcJBIkA6KKJBI9LbhjviY4sPEStN1V4yIb5gkfpkoouHL/JFsGsTktbELwNgknCfVwWI9yiivh/icuf+QLxFWpTa4ZhRRWJ9dGZdWI2yWRUpFpjdRRM9H4821s5+YPJUUUSOrij/9k=",
                    CategoryId = 1
                },
                new Product
                {
                    Id = 4,
                    CategoryId = 2,
                    Title = "The Matrix",
                    Description = "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg",
                },
                new Product
                {
                    Id = 6,
                    CategoryId = 2,
                    Title = "Back to the Future",
                    Description = "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg"
                },
                new Product
                {
                    Id = 7,
                    CategoryId = 2,
                    Title = "Toy Story",
                    Description = "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. The film was directed by John Lasseter (in his feature directorial debut), and written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten. Taking place in a world where anthropomorphic toys come to life when humans are not present, the plot focuses on the relationship between an old-fashioned pull-string cowboy doll named Woody and an astronaut action figure, Buzz Lightyear, as they evolve from rivals competing for the affections of their owner, Andy Davis, to friends who work together to be reunited with Andy after being separated from him.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg",

                },
                new Product
                {
                    Id = 8,
                    CategoryId = 3,
                    Title = "Half-Life 2",
                    Description = "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",

                },
                new Product
                {
                    Id = 9,
                    CategoryId = 3,
                    Title = "Diablo II",
                    Description = "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png",
                },
                new Product
                {
                    Id = 10,
                    CategoryId = 3,
                    Title = "Day of the Tentacle",
                    Description = "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg"         
                },
                new Product
                {
                    Id = 11,
                    CategoryId = 3,
                    Title = "Xbox",
                    Description = "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg",
                },
                new Product
                {
                    Id = 12,
                    CategoryId = 3,
                    Title = "Super Nintendo Entertainment System",
                    Description = "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg",
                }
            );


            modelBuilder.Entity<ProductVariant>().HasData(
                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId = 2,
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId = 3,
                    Price = 7.99m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId = 4,
                    Price = 19.99m,
                    OriginalPrice = 29.99m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    ProductTypeId = 2,
                    Price = 7.99m,
                    OriginalPrice = 14.99m
                },
                new ProductVariant
                {
                    ProductId = 3,
                    ProductTypeId = 2,
                    Price = 6.99m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    ProductTypeId = 5,
                    Price = 3.99m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    ProductTypeId = 6,
                    Price = 9.99m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    ProductTypeId = 7,
                    Price = 19.99m
                },
                new ProductVariant
                {
                    ProductId = 5,
                    ProductTypeId = 5,
                    Price = 3.99m,
                },
                new ProductVariant
                {
                    ProductId = 6,
                    ProductTypeId = 5,
                    Price = 2.99m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    ProductTypeId = 8,
                    Price = 19.99m,
                    OriginalPrice = 29.99m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    ProductTypeId = 9,
                    Price = 69.99m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    ProductTypeId = 10,
                    Price = 49.99m,
                    OriginalPrice = 59.99m
                },
                new ProductVariant
                {
                    ProductId = 8,
                    ProductTypeId = 8,
                    Price = 9.99m,
                    OriginalPrice = 24.99m,
                },
                new ProductVariant
                {
                    ProductId = 9,
                    ProductTypeId = 8,
                    Price = 14.99m
                },
                new ProductVariant
                {
                    ProductId = 10,
                    ProductTypeId = 1,
                    Price = 159.99m,
                    OriginalPrice = 299m
                },
                new ProductVariant
                {
                    ProductId = 11,
                    ProductTypeId = 1,
                    Price = 79.99m,
                    OriginalPrice = 399m
                }
            );
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }
    }
}
