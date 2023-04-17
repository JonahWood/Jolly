import { AppState } from "../AppState"
import { logger } from "../utils/Logger"
import Pop from "../utils/Pop"
import { api } from "./AxiosService"

class PasswordsService{
async getPW(input){
    const res = await api.get('api/password')
    logger.log('passss', res.data)
    const foundPass = res.data.find(p => p.kee == input)
    if(foundPass){
        AppState.PWCheck = true
    } else {
        Pop.error('INCORRECT')
    }
}
}
export const passwordsService = new PasswordsService