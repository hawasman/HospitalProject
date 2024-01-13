import { useTranslation } from 'react-i18next'
import { useRouteError } from 'react-router-dom'

const ErrorPage: React.FC = () => {
  const error: unknown = useRouteError()
  const { t } = useTranslation()
  return (
    <div
      id='error-page'
      className='flex flex-col gap-8 justify-center items-center h-screen'
    >
      <h1 className='text-4xl font-bold'>{t("error.oops")}</h1>
      <p>{t("error.sorry")}</p>
      <p className='text-slate-400'>
        <i>
          {(error as Error)?.message ||
            (error as { statusText?: string })?.statusText}
        </i>
      </p>
    </div>
  )
}

export default ErrorPage