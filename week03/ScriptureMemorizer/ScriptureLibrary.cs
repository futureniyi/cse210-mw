using System.Collections.Generic;

public static class ScriptureLibrary
{
    public static List<ScriptureEntry> GetScriptures()
    {
        return new List<ScriptureEntry>
        {
            new ScriptureEntry(
                new Reference("John", 3, 16),
                "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."
            ),
            new ScriptureEntry(
                new Reference("Jeremiah", 29, 11),
                "For I know the thoughts that I think toward you, saith the Lord, thoughts of peace, and not of evil, to give you an expected end."
            ),
            new ScriptureEntry(
                new Reference("Romans", 8, 28),
                "And we know that all things work together for good to them that love God, to them who are the called according to his purpose."
            ),
            new ScriptureEntry(
                new Reference("Philippians", 4, 13),
                "I can do all things through Christ which strengtheneth me."
            ),
            new ScriptureEntry(
                new Reference("Psalm", 23, 1),
                "The Lord is my shepherd; I shall not want."
            ),
            new ScriptureEntry(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."
            ),
            new ScriptureEntry(
                new Reference("Matthew", 11, 28, 29),
                "Come unto me, all ye that labour and are heavy laden, and I will give you rest. Take my yoke upon you, and learn of me; for I am meek and lowly in heart: and ye shall find rest unto your souls."
            ),
            new ScriptureEntry(
                new Reference("Isaiah", 41, 10),
                "Fear thou not; for I am with thee: be not dismayed; for I am thy God: I will strengthen thee; yea, I will help thee; yea, I will uphold thee with the right hand of my righteousness."
            ),
            new ScriptureEntry(
                new Reference("Philippians", 4, 6, 7),
                "Be careful for nothing; but in every thing by prayer and supplication with thanksgiving let your requests be made known unto God. And the peace of God, which passeth all understanding, shall keep your hearts and minds through Christ Jesus."
            ),
            new ScriptureEntry(
                new Reference("Psalm", 121, 1, 2),
                "I will lift up mine eyes unto the hills, from whence cometh my help. My help cometh from the Lord, which made heaven and earth."
            ),
            new ScriptureEntry(
                new Reference("Matthew", 28, 19, 20),
                "Go ye therefore, and teach all nations, baptizing them in the name of the Father, and of the Son, and of the Holy Ghost: Teaching them to observe all things whatsoever I have commanded you: and, lo, I am with you alway, even unto the end of the world. Amen."
            ),
            new ScriptureEntry(
                new Reference("Romans", 12, 1, 2),
                "I beseech you therefore, brethren, by the mercies of God, that ye present your bodies a living sacrifice, holy, acceptable unto God, which is your reasonable service. And be not conformed to this world: but be ye transformed by the renewing of your mind, that ye may prove what is that good, and acceptable, and perfect, will of God."
            ),
        };
    }
}
