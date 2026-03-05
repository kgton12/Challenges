namespace CodeWars;

public class HighestScoringWord
{
    public static string High(string s)
    {

    }
}
//export const high = (str: string): string => {
//	type HighScore = {
//        word: string;
//score: number;
//	};

//const output: HighScore[] = [];

//str
//    .toLowerCase()
//    .split(" ")
//    .map((value) => {
//    const calculateWordScore = lettersToScore(value);
//    output.push({ score: calculateWordScore, word: value });
//		});

//return output.sort((a, b) => b.score - a.score)[0].word;
//};

//function lettersToScore(str: string): number {
//	const initLetterAscii = 97;

//return str.split("").reduce((prev, curr) => {
//    const score = curr.charCodeAt(0) - initLetterAscii + 1;

//    return prev + score;
//}, 0);
//}