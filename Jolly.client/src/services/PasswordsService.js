import { logger } from "../utils/Logger"
import { api } from "./AxiosService"

class PasswordsService{
async getPW(input){
    const res = await api.get('api/password')
    logger.log('passss', res.data)
}
}
export const passwordsService = new PasswordsService