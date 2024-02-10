import { z } from "zod"

export const contactInfoSchema = z.object({
  id: z.number(),
  updatedAt: z.string(),
  createdAt: z.string(),
  userId: z.number(),
  activeField: z.boolean(),
  phone1: z.string(),
  phone2: z.string(),
  mobilePhone: z.string(),
  email: z.string(),
  address: z.string(),
  city: z.string()
})

export const financialInfoSchema = z.object({
  id: z.number(),
  updatedAt: z.string(),
  createdAt: z.string(),
  userId: z.number(),
  activeField: z.boolean(),
  patientType: z.string(),
  companyNo: z.string(),
  patientClass: z.string(),
  debtSet: z.number(),
  discount: z.number(),
  insuranceAccount: z.string(),
  insuranceExp: z.string(),
  notes: z.string(),
  initialCredit: z.number(),
  currenctCredit: z.number()
})

export const attachmentSchema = z.object({
  id: z.number(),
  updatedAt: z.string(),
  createdAt: z.string(),
  userId: z.number(),
  activeField: z.boolean(),
  name: z.string(),
  type: z.string(),
  path: z.string(),
  size: z.string(),
  notes: z.string()
})

export const treatmentHistorySchema = z.object({
  id: z.number(),
  updatedAt: z.string(),
  createdAt: z.string(),
  userId: z.number(),
  activeField: z.boolean(),
  type: z.string(),
  doctorId: z.number(),
  clinicid: z.number(),
  symptoms: z.string(),
  examinations: z.array(z.string()),
  analysis: z.array(z.string()),
  diagnosis: z.string(),
  treatment: z.array(z.string()),
  services: z.array(z.string()),
  medicalFileId: z.number(),
  medicalFile: z.string()
})

export const appUserSchema = z.object({
  id: z.number().optional(),
  tenantId: z.string().optional(),
  userName: z.string().optional(),
  email: z.string(),
  password: z.string()
})

export const authTokenSchema = z.object({
  accessToken: z.string(),
  expiresIn: z.number(),
  refreshToken: z.string()
})

export const iAuthSchema = z.object({
  login: z
    .function()
    .args()
    .returns(z.void()),
  tokenData: authTokenSchema,
  logout: z
    .function()
    .args()
    .returns(z.void()),
  isAuth: z.boolean()
})

export const medicalFileSchema = z.object({
  id: z.number(),
  updatedAt: z.string(),
  createdAt: z.string(),
  userId: z.number(),
  activeField: z.boolean(),
  patientId: z.number(),
  bloodType: z.string(),
  bloodPressure: z.string(),
  heatDgree: z.number(),
  pulseRate: z.number(),
  sugarLevel: z.number(),
  weight: z.number(),
  hieght: z.number(),
  allergies: z.array(z.string()),
  notes: z.string(),
  treatmentHistory: z.array(treatmentHistorySchema).optional()
})

export const patientSchema = z.object({
  id: z.number(),
  updatedAt: z.date().optional(),
  createdAt: z.date().optional(),
  userId: z.number().optional(),
  activeField: z.boolean(),
  fullNameEnglish: z.string().optional(),
  fullNameArabic: z.string(),
  nationality: z.string(),
  gender: z.string(),
  contactInfo: contactInfoSchema.optional(),
  financialInfo: financialInfoSchema.optional(),
  attachments: z.array(attachmentSchema).optional(),
  medicalFile: medicalFileSchema.optional()
})
