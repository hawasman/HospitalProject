import { Card } from "antd";
import { FieldValues, useForm } from "react-hook-form";
import { useTranslation } from "react-i18next";
import { login, useAuth } from "../Service/AuthService";
import { AppUser } from "../interfaces";
import { useNavigate } from "react-router-dom";

const LoginPage = () => {
  const { setToken } = useAuth();
  const navigate = useNavigate();

  const { t } = useTranslation();
  const {
    register,
    handleSubmit,
    reset,
    formState: { errors, isSubmitting },
  } = useForm();

  const onSubmit = async (data: FieldValues) => {
    const user: AppUser = { email: data.email, password: data.password };
    await login(user).then(async (res) => {
      if (!res) {
        return;
      }
      setToken(JSON.stringify(res.data));
    });
    reset();
    navigate("/", { replace: true });
  };

  return (
    <>
      <div className="flex h-screen">
        <div className="m-auto">
          <Card
            title={t("form.login")}
            className="relative mx-auto w-full max-w-md bg-white px-6 pt-10 pb-8 shadow-xl ring-1 ring-gray-900/5 sm:rounded-xl sm:px-10"
          >
            <div className="mt-5">
              <form onSubmit={handleSubmit(onSubmit)}>
                <div className="relative mt-6">
                  <input
                    {...register("email", { required: true })}
                    type="email"
                    placeholder={t("form.email")}
                    className="w-full"
                  />
                  {errors.email && <p>{`${errors.email.message}`}</p>}
                </div>
                <div className="relative mt-6">
                  <input
                    {...register("password", { required: true })}
                    type="password"
                    placeholder={t("form.password")}
                  />
                  {errors.password && <p>{`${errors.password.message}`}</p>}
                </div>
                <div className="my-6">
                  <button disabled={isSubmitting} type="submit">
                    {t("form.login")}
                  </button>
                </div>
              </form>
            </div>
          </Card>
        </div>
      </div>
    </>
  );
};

export default LoginPage;
