export interface Option {
    Id: number;
    Name: string;
    Votes: number;
}

export interface Poll {
    Id: number;
    Name: string;
    Options: Option[];
}