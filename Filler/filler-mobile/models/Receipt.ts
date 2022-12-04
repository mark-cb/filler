import { FuelType } from "./fuelType";


export interface Receipt {
    id: string;
    userId: string;
    fuelType: FuelType;
    litres: number;
    fillTime: string;
    total: number;
}
