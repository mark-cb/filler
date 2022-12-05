import { Pump } from "./pump";

export interface Site {
    siteId: number;
    name: string | null;
    latitude: number;
    longitude: number;
    numberOfPumps: number;
    fuelServed: string[];
    fuelCost: number;
    pumps: Pump[];
}
