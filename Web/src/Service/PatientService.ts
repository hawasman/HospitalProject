import { MedicalFile, Patient, TreatmentHistory } from "../interfaces";
import { axiosInstance } from "./Apis";

const patientsURL = "/Patients";
const medicalFileURL = "/MedicalFiles";
const treatmentHistoryURL = "/TreatmentHistory";

//#region  Patients
export async function getPatients() {
  const data = (await axiosInstance.get<Patient[]>(patientsURL)).data;
  return data;
}

export async function getPatientbyId(id: number) {
  const data = (await axiosInstance.get<Patient>(`${patientsURL}/${id}`)).data;
  return data;
}
//#endregion

//#region MedicalFile
export async function getMedicalFileByPatientId(id: number) {
  const data = (
    await axiosInstance.get<MedicalFile>(`${medicalFileURL}/patient/${id}`)
  ).data;
  return data;
}
//#endregion

//#region TreatmentHistory

export async function getTreatmentByMedicalFileId(id: number) {
  const data = (await axiosInstance.get<TreatmentHistory[]>(
      `${treatmentHistoryURL}/medicalFile/${id}`
  )).data;
  return data
}

//#endregion
