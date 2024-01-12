export interface Patient {
    id: number
    updatedAt?: Date
    createdAt?: Date
    userId?: number
    activeField: boolean
    fullNameEnglish?: string
    fullNameArabic: string
    birthDate: Date
    nationality: string
    gender: string
    socialState: number
    religion: string
    nationalId: string
    job?: string
    contactInfo?: ContactInfo
    financialInfo?: FinancialInfo
    attachments?: Attachment[]
    medicalFile?: MedicalFile
  }
  
  export interface ContactInfo {
    id: number
    updatedAt: string
    createdAt: string
    userId: number
    activeField: boolean
    phone1: string
    phone2: string
    mobilePhone: string
    email: string
    address: string
    city: string
  }
  
  export interface FinancialInfo {
    id: number
    updatedAt: string
    createdAt: string
    userId: number
    activeField: boolean
    patientType: string
    companyNo: string
    patientClass: string
    debtSet: number
    discount: number
    insuranceAccount: string
    insuranceExp: string
    notes: string
    initialCredit: number
    currenctCredit: number
  }
  
  export interface Attachment {
    id: number
    updatedAt: string
    createdAt: string
    userId: number
    activeField: boolean
    name: string
    type: string
    path: string
    size: string
    notes: string
  }
  
  export interface MedicalFile {
    id: number
    updatedAt: string
    createdAt: string
    userId: number
    activeField: boolean
    patientId: number
    patient: Patient
    bloodType: string
    bloodPressure: string
    heatDgree: number
    pulseRate: number
    sugarLevel: number
    weight: number
    hieght: number
    allergies: string[]
    notes: string
    treatmentHistory?: TreatmentHistory[]
  }
  
  export interface TreatmentHistory {
    id: number
    updatedAt: string
    createdAt: string
    userId: number
    activeField: boolean
    type: string
    doctorId: number
    clinicid: number
    symptoms: string
    examinations: string[]
    analysis: string[]
    diagnosis: string
    treatment: string[]
    services: string[]
    medicalFileId: number
    medicalFile: string
  }
  