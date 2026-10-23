1. Which of the three operations may need to inspect every player?
    Answer: Score needs to check every player, as it shouldn't stop till it knows that there isn't any player with a higher score.

2. If the number of players becomes 100 times larger, which operation(s) do you expect to become noticeably more expensive?
    Answer: Score, as it needs to check every player and doesn't stop till it has.

3. What information could we organize differently if finding players by ID became extremely common?
    Answer: No clue, might come back to this later, might not.

4. What edge case did you choose to test, and why?
    Answer: A few: duplicate ids, and duplicate high scores. Because they only return one value, it's good to know which one it returns and that it returns the most important one.
    
5. At what point did you make a Git commit? What made that a sensible checkpoint?
    Answer: Making every method function.
    