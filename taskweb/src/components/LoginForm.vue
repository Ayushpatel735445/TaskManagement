<template>
    <v-container>

        <v-app-bar app color="primary" dark>
            <div class="d-flex align-center">
                <v-img alt="Vuetify Logo" class="shrink mr-2" contain
                    src="data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAkGBwgHBgkIBwgKCgkLDRYPDQwMDRsUFRAWIB0iIiAdHx8kKDQsJCYxJx8fLT0tMTU3Ojo6Iys/RD84QzQ5OjcBCgoKDQwNGg8PGjclHyU3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3N//AABEIALcAwgMBIgACEQEDEQH/xAAbAAEAAgMBAQAAAAAAAAAAAAAAAQUDBAYHAv/EAEkQAAEDAgMEBQcIBwcEAwAAAAEAAgMEEQUSIQYTMUEUIlFTYRVxgZGSotEHIzI2dKGxwRYzQlJic7IkVXKCk+HwJqPS4hclNP/EABcBAQEBAQAAAAAAAAAAAAAAAAABAgP/xAAhEQEBAAICAgIDAQAAAAAAAAAAAQIREiExQTJRAyJCE//aAAwDAQACEQMRAD8A9r6NB3EXsBOjQdxF7AWVFUYujQdxF7ATo0HcRewFlRBi6NB3EXsBOjQdxF7AWVEGLo0HcRewE6NB3EXsBZUQYujQdxF7ATo0HcRewFlRBi6NB3EXsBOjQdxF7AWVEGLo0HcRewE6NB3EXsBZUQYujQdxF7ATo0HcRewFlRBi6NB3EXsBOjQdxF7AWVEGLo0HcRewE6NB3EXsBZUQYujQdxF7ATo0HcRewFlRBi6NB3EXsBOjQdxF7AWVEGLo0HcRewEWVEBERAREQEREBERARfLnWVFUbQQyQzCgN5N24xPkbla94AOUZrakOBHG+vYUF+eHC6wuqYW/SlYLanM4C3P8ASuaNJiOKQOc+SQxywyxZZQY23zsAdltfrMaT4XcBoUOzNTJJO+euY58rcrnCG9zka2/HTg46c3eAUHSmphDxHvWZyL5cwvbzLIDdUwwmWSqhqKqeKV0cjXOa2IgHKx7RoSeb78+CYfRPw6ipKSMnO54MsjbkAAXIF+XVDR4IsXaLnRtExlXOJmf2VsromPabuu36ZIHIWPYbZbA5grynnjnbnieHtuRdvIg2I9HxRGZERUEREBERAREQEREBERAREQEREBfD3NaASQ3Wwuvtc9iWMhtc2iZSCsiJEctns0cf2dXWzfwute+hJFkVp422uxOrfhzm7lwfmia5hfFNHp1nEc2kX5WJAF7hyusOwyKjhDHNEp3plLntBOc6F3gTxJ5knhdbMDDTxkOlc6MG7d4dWjsvz9Oqx1hfk30Eh6jXHKDo4W4rOxsSzRwx55XBjQdSeS1KarfKw76LILOdmY8FoaCQ3XQ3I14flf5kuKPJSPdG2N7RvC3NduYZuPhfXzr6gBgoru65fZoFvM0D8PvV9J7fGEwPoqeOlmmnnkIMjpJnZiL8ifT9xW3BPDUSTNic4mF+R4LSAHWB7PEKrYY2zQR1Exe2QGCWIszNkl046E6BrtL21HaFtfqqkMjls0yAy5XAlpLbAG/L6NufrV0b2y1uH01UWPliaZoyHMkLdWuHA+NjY2XOuFbg+JtjgbvWSDqRAH57Ugue4A9b6L3Oy6aAaZiriifPTGV1RUy1baiqIhIisImngDb9m4489O1ZXPoMVfPRPySmAjexG4y34DxHEHlxBUXTZoayGtgbPC9rmnjYg2PZoSPVotpcjhk82G45LSOa7dPfl3MMZIaTlseJsALftXsB1WtautBuLoiURFQREQEREBERAREQEREBEQ8EGCsmdT0s0rI3SOYxzhGzi4gcB4qgwSgecRdUSul+aLrNdCYus83d9IG41v1X5b62GisdonNbhzmyNzRuc1r7SZCATqQbi504fcsWzETYcPdka5okmke1zrFzhewJ0HK3LThyBMG/VuDiyAMz7y+bW1m21P3gelfEMYfQmmAy5WGI+Glv+eda+I1boKuBkjGNY43jfvbPLxqW2I4Zb639CyiqiEj5GvD2GO/VIuXNvcHxtb1Jx9nL0RSyy1DWARiHd9ZnNruz/nh2hfNG3KWNkkvHGLxk8tSNe2359uqwQVxnr8ooamOSOBr3l7RYh3Ft/3h8VE0TaxrYtzvo3uzhkgHAOucwPaQCDxv5lZNG9srXP3r44tZA52UW0bd5uT6LevzrWr6d1P0yfD6OKWeoljbOXOy3ZYda9+V/wATqt1hIi6T9F2d2YHmMxFvPoLf7r4ldK+KRsUjY3vfmkc9mdsbRa4PiWi1uVyql8JmzZWyjKXROyOA0zWItb0gfeFmhcyCqEG7eZpmmR8jWdW4sNTyPIeA8Fr0bnPYwtheWsJEbSMoAFwCb21t5+aiJtX5SiLKiB1OWF0w5vPLKewaevtKlanhpbWUTpIopIGSOLzu5WRX+caA4hp1Atx4346C5Vrg9QamhY9xBe0lj+u12oNr3aANRY2sOPBY8dgjqMJqmSNzNDM9rXBynMNMrr8OGU37CtTZZ8zoJWTRlmRwtd3aL8OWltAANeF7qIvkRFQREQEREBERAREQEREBEQ8EFXtDvDQDctc528bq08PHxUbOgDD8pYGPbI8PF7m5N78Ta9wbeK3aylhrYNzMCYyQ7quLSCDcEEcNQvmgoqfD4dzSsyR34XJvoBqTcnQBBkmYSy8Za199C5twO3RVkNZS4hH1Zaepbms10ZyuBHYCeIPirkrRqIXU9G9lDSwOeXfqzZjTc6k6eJPihpiZM6KSU1IIkEd2gAXc0XPInXjp+S+4x0R4dIbiX9YRwz8dPDiPQO0303U9TFVPjkEL6GRga0XcJTJ23tYC35BZnTua2JtUPnYnhzsuoeCCLjzXvbwVRLGiSCOebM4O6zI2mxJdr+fPgmXM2CiZIAWDNI8crfnc3t5vMsQnEcULQdWU7RmbrlvcH09XQ+DieCltJNVQSsDpKUPFgQLuI7Rc+J+kNdSRroEsgdmdLTOfnJsMzQWMYBYNF7acDpfn2rdoqKKlY0MYxthazW2DRcmwHpWdgytAuXHtI4rIorRxzdDB6wT23boHtN+Fi0+LfxHnHFVeyLBuJphHG0vfYuY7NmALrEnM4a3J48TzV7UwsqYXxSFwadCWkg+gjVaOC4fJh1O6KWoM7i/NvLHsA5kk8L8eZ8EFmiIgIiICIiAiIgIiICIiAiIgIiICIiCLLTxKES0ziB12AuYfEcvUt1Yar/8ANL/gP4J7KosDcKqpaSbsEYkbfmCSW/iuiAXMbH/Rh+xRLqFrLymPgREWVEREBERAREQEREBERAREQERfEgzMcBxIIQfWim684bsBjDWt/wCoHEgD9/U+0tTFdjsVwzDqitkxp8ggYXFoLwT7y1MZ9udzynp6igXkezWzuJbQUElXBi8kDWTGLK57zwAP73j9yt/0Axj+/nf9z/yTjPsmdvp6KpuuH2jmm2a2IZRPqjLVS/MNlBIvckuPb9G49S5zY2vrcK2lo4a+aZ0NbE0N3khdo8XjdqeZ09J7EmHWy56unraxVALoJGgXJaQPUsg4FauIVkFBSTVdU8NihZmc619PDtKy6dKrZyimpHtE0ZblpmR38Ror+4XmceKbTbX1UrcHPQaJrrGRrstvBzxqXeDeHPlfYOw2PD5xu0chl/myj78y3Zu9ucyuuo9FuhXmLMc2j2TrY4ccBq6R+gcXZrjta/j6HKw+UiuE2z+GVdFUP3c1QC2SN1rgscRwWeHa8+tu+RVGyZLtmsLLiXONLGSSbn6IVueCl6um53EKQuU2x2qhwGn3MBbJiEjeownRg/ed4dg5qu2J2drXTNxjGpp3TPOeKCR7tDxzvF+PY3l5+F4s8pbqO8REUaEREBERAREQEREBUm2f1WxL+QVdqk2z+q2JfyCk8pl8VL8lP1fqPtbv6GLtCuL+Sr6v1H2t39DF1OK1seHYdU1kp6kEZkI5mw4elXL5M4/B55tg520O2lHg0dzDCQx9uV+s/wBTbD0FbnyoYbu4KPFKcZHQOEDi3kOLT5gb+0sfyZUUlXiGIY3VAl7iYwTzc45nn8PWV2uO4e3FMIqaF+hmjLWnsdxB9BAWt6sjMx3LkbPYi3FsGpK1pF5YwXgcnDRw9d1Q/Ke97dmg1n0X1DA/zC5/EBVnyW4g+M12ET6PjfvWMPK1mvHoNvWV2OO4XFjGFVFDMSBIOq618rgbgj0jgp4yWXng0dho4o9lsO3WXrR5nW/eJJd9/wCCv+IXlVHiGPbDk01XR76hzXbqcniWvHC/Eg+rUroqD5RsInA6XHUUvaSzeN9bbn7kuN8mOcnVW+2WGOxXZ+qp4ojJUBofCBa+cdl+3UelefY1SV1BsTQ0uJQOhfFiDt2xxB6hY48r8yV6jh+JUOJxiSgqoahg47t4JHnHL0rkvlYH/wBPRWBP9r4D/A5XC2WRPyYy42ui2SNtl8L+yR/0qv2x2ohwGmDIS2Sukb83GTo0fvO8Px9arH7Sw4BsbhQbkkrpKKPcw3uPojru/h/Hh225zY/ouIbWOkx90j6p5zxCVtg+Tlm7Da1hw9QCTHvdLl1JF5sXsvNU1Dcdx3NJUPfvYo5eN+T3fkOXHsA9ADbcNB2BQ22lvuX2s3LddMcZIIiKKIiICIiAiIgIiICpNs/qtiX8gq7VJtn9VsS/kFJ5TL4qX5Kvq9U/a3f0MWD5VMS3WG0+Gxnr1Ls7x/Cw/m4j1FZ/kq+r9T9rd/QxUIaNrPlBcHgSUdOesCLgxx/k559RK3/W3LesJFhs1tdgODYLS0bn1Bka28pbCSC86kjw7PAK1/8AkPATpmqf9E/FWv6L4D/dFF/oN+CfovgP9z0X+g34KW47WY5yaeaSY3RUe2jMYw97uiSSB0oc3LYO0fp2cXelewtIygg3B5rh9vNmaCLAX1WHUUNPJTvEjtzGBmZwN7dl7+hc9ieM1tTsfhVRS1lRDLTyOpJ91IWkkNuwn0AFasmU6TG3C9vWnND2kEXBGoKpMQ2SwOuDjLh8LXn9uEbt1/O3j6VuYDXsxLCKSsY6+9ibm1vZ3Aj13ViufcddSvMsc2JqMGzYpgNXMRAC9zD+sa3nlItfzfjwVdtBj78c2So31Ib0mCt3cuUaO+bcQ4ecfeD4L1irkjhpZpZ3BsTGOc8nkANV4LFG7yM+QtIb0mJg7AQyW4+8Lrh33XD8n69R22w+yfTdzi2MNL4w1vR4XG+YAaE/w6aD09isPlC2cfWReV8PaRVwC8gZoZGjg7TXM3kezTiAuj2RH/TGF/ZI/wCkK1ssXK8tukxlx05fYbaQY3Rbmpd/boAN4O8byeB+PYT4hdUF5ftdhE+zOMMxzBxlgfJd7QNI3Hi0/wALv9uxd5s/jFPjWGx1lMbXNnxk3LHcwf8AnCxTKe4uNvxq0REWGxERUEREBERAREQFR7afVbEv5BVe/G8SgeRM6l0M1huXNLskhYOL+xubQH0W1YhtFXxPqehU8ckDDeF5jcRI3I+5BBto9o17L+dPF2Wb6c5szifknYDFKmN1pulOZD/jcxgHq1PoVt8leGdHwuXEHtsal2WPwY3/ANr+oLcG0Nc2UM3LTllcH/MuIDdG2vm4hzm3JtwOg0KzYZjlZVVtPBUwNjY5rhKd24WdYka8AOpJx4gtPn1y3GJh4rp0XIR7RVroy+SFjHtje9sToH3kcWlzGjXQgFlydDflcL4ftFiYzgNpmZMjXZoXDd/qg5zruFhd7wOFsvE2Kw26yqhjqIJYJmh0crCx7TzBFiF5TszRsjxfEtlsUcd1U3jB5iRmrXDsu25vz0XXHHcWMsrIqemcWFzWkxuAcd41g/a4We0/5Tw5bGLYtiFI+qMTYBFFlaJHxOIuWZtesOJ04cxryWpdM5Y7clBTbU7G1EgpYnVlC51yGMMjD45R1mH7vPZbo+Uudp3cmDfODiOkEa+bJdXrcaxHo+JSPjiYaeUCHNE6xbvnx69bU2Zxu0XNyQ3VYhtDXghz4I2M3jQS+NzbsOa7tTpwtrwse0K8p9M8MvVc9V1m1O1wFJFQmionHrlwLWkfxOI62vIBTtngsGB7KYdRwEvtWZpJCNZHZHa+bh6gNV19RjExwuqko9zNUsl3cTGtLhYvs0kXudNfQq2XaTEsr3w08QG8JjDonkyMtNlA1HWLo2jnx4aiyZaP857XWyX1Ywv7LH/SFbrmMRxqvpq+rjjhY6OBwyExuJeMgc+1jxb5tcwHEa6/6RYgwvcYIyGy5CBC+7etJx116sYd/nHhfNbk1HT1lLDWU0lPUxNkhkaWvY7mF5dC6r2B2jLHCSbD5/A/OMvof8bfv17QuwZjlW6KmbJ0aKofM1szC09Vro81vpDW9xfw4LW/STEhAXiOB7ty57C2BwEp3bnaXfplcA02JvfkrLpMsd9usppo6mGOenkbJFI0Oa9puHDtWZamGyuno4Znua572gksFgT4akfeVtqNCIiAiIgIiICIiCLJlUogiyWUogiyWUogiyZVKIIypZSiCLJZSiCLJlUogiyWUoggKURAREQEREGp5Ro+9913wTyjR977rvgoRRpPlGj733XfBPKNH3vuu+ChEE+UaPvfdd8E8o0fe+674KEQT5Ro+9913wTyjR977rvgoRBPlGj733XfBPKNH3vuu+ChEE+UaPvfdd8E8o0fe+674KEQT5Ro+9913wTyjR977rvgoRBPlGj733XfBPKNH3vuu+ChEE+UaPvfdd8E8o0fe+674KEQT5Ro+9913wTyjR977rvgoRBPlGj733XfBPKNH3vuu+ChEE+UaPvfdd8E8o0fe+674KEQT5Ro+9913wUIiD//2Q=="
                    transition="scale-transition" width="40" />
               <h1>Task Management</h1>
            </div>

            <v-spacer></v-spacer>

            <v-btn href="https://github.com/vuetifyjs/vuetify/releases/latest" target="_blank" text>
                <span class="mr-2">Sign up</span>
                <v-icon>mdi-open-in-new</v-icon>
            </v-btn>
        </v-app-bar>

        <v-form>
            <v-text-field v-model="email" label="Email" type="email" required></v-text-field>

            <v-text-field v-model="password" label="Password" type="password" required></v-text-field>

            <v-btn color="primary" @click="submitForm">Login</v-btn>
        </v-form>
    </v-container>
</template>

<script>

export default {
    data() {
        return {
            email: '',
            password: '',
        };
    },
    methods: {
        submitForm() {
            // Handle form submission logic here
            console.log('Email:', this.email);
            console.log('Password:', this.password);
        }
    }
};
</script>

<style scoped>
/* Add your styles for LoginForm here */
</style>