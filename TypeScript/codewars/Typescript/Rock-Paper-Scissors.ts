export function rps(p1: string, p2: string): string {
    type GameRules = Record<"rock" | "paper" | "scissors", { win: string; lose: string }>;

    const GAME: GameRules = {
        rock: { win: "scissors", lose: "paper" },
        paper: { win: "rock", lose: "scissors" },
        scissors: { win: "paper", lose: "rock" },
    };

    if (p1 === p2) return "Draw!";

    return p2 === GAME[p1 as "rock" | "paper" | "scissors"].win ? "Player 1 won!" : "Player 2 won!";
}

