import { purple } from "@mui/material/colors";
import axios from "axios";
import { Poll } from "../interfaces/PollInterfaces";
const BASE_URL = "http://localhost:5179"
export const GetPolls = async () : Promise<Poll[]> => {
    const response: Poll[] = await axios.get(BASE_URL + "/api/v1/Poll");
    return response;
}