import { FuelType } from "./fuelType";
import { Pump } from "./pump";

export interface Receipt {
    id: number;
    fuelType: FuelType;
    litres: number;
    fillTime: string;
    total: number;
    usedPump: Pump;
    userId: string;
}
