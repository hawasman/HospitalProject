import { MedicalFile, Patient, TreatmentHistory } from "../interfaces";
import { axiosInstance } from "./Apis";

const patientsURL = "/Patients";
const medicalFileURL = "/MedicalFiles";
const treatmentHistoryURL = "/TreatmentHistory";

//region Patient

/**
 * Retrieves a list of patients from an API endpoint.
 * @returns {Promise<Patient[]>} An array of Patient objects representing the list of patients retrieved from the API endpoint.
 */
export async function getPatients(): Promise<Patient[]> {
  const response = await axiosInstance.get<Patient[]>(patientsURL);
  return response.data;
}

/**
 * Retrieves a patient by their ID.
 *
 * @param {number} id - The ID of the patient to retrieve.
 * @return {Promise<Patient>} A Promise that resolves with the patient data.
 */
export async function getPatientbyId(id: number): Promise<Patient> {
  const response = await axiosInstance.get<Patient>(`${patientsURL}/${id}`);
  return response.data;
}

/**
 * Creates a new patient.
 *
 * @param {Patient} patient - The patient object to be created.
 * @return {Promise<Patient>} The created patient object.
 */
export async function createPatient(patient: Patient): Promise<Patient> {
  const response = await axiosInstance.post<Patient>(patientsURL, patient);
  return response.data;
}

//#endregion

//#region MedicalFile

/**
 * Retrieves a medical file by patient ID.
 *
 * @param {number} id - The patient ID.
 * @return {MedicalFile} The medical file data.
 */
export async function getMedicalFileByPatientId(id: number): Promise<MedicalFile> {
  const response = await axiosInstance.get<MedicalFile>(
    `${medicalFileURL}/patient/${id}`
  );
  return response.data;
}

//#endregion

//#region TreatmentHistory

/**
 * Retrieves the treatment history associated with a given medical file ID.
 *
 * @param {number} id - The ID of the medical file.
 * @return {TreatmentHistory[]} - An array of treatment history objects.
 */
export async function getTreatmentByMedicalFileId(id: number): Promise<TreatmentHistory[]> {
  const response = await axiosInstance.get<TreatmentHistory[]>(
    `${treatmentHistoryURL}/medicalFile/${id}`
  );
  return response.data;
}

//#endregion
