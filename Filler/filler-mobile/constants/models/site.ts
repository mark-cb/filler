export interface Site {
    id: string;
    name: string | null;
    latitude: number;
    longitude: number;
    numberOfPumps: number;
    fuelServed: string[];
    fuelCost: number;
}


