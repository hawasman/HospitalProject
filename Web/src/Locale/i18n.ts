import i18n from 'i18next';
import { initReactI18next } from 'react-i18next';
import en from './en.json'
import ar from './ar.json'

i18n.use(initReactI18next).init({
  fallbackLng: 'ar',
  lng: 'ar',
  resources: {
    en: {
      translations: en
    },
    ar: {
      translations: ar
    }
  },
  ns: ['translations'],
  defaultNS: 'translations'
});

i18n.languages = ['en','ar'];

export default i18n;