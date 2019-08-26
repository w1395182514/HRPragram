using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using EFentity;
using IHRDAL;
using System.Data;

namespace HRDAL
{
    public class EngageResumeDAL : DaoBase<engage_resume>, IEngageResumeDAL
    {
        public int TKtAdd(engage_resumeModel st)
        {
            engage_resume est = new engage_resume()
            {
                res_id = st.res_id,
                human_address = st.human_address,
                human_age = st.human_age,
                human_birthday = st.human_birthday,
                human_birthplace = st.human_birthplace,
                human_college = st.human_college,
                human_educated_degree = st.human_educated_degree,
                human_educated_major = st.human_educated_major,
                human_educated_years = st.human_educated_years,
                human_email = st.human_email,
                human_history_records = st.human_history_records,
                human_hobby = st.human_hobby,
                human_homephone = st.human_homephone,
                human_idcard = st.human_idcard,
                human_major_id = st.human_major_id,
                human_major_kind_id = st.human_major_kind_id,
                human_major_kind_name = st.human_major_kind_name,
                human_mobilephonej = st.human_mobilephonej,
                human_major_name = st.human_major_name,
                human_name = st.human_name,
                human_nationality = st.human_nationality,
                human_party = st.human_party,
                human_picture = st.human_picture,
                human_postcode = st.human_postcode,
                human_race = st.human_race,
                human_religion = st.human_religion,
                human_sex = st.human_sex,
                human_specility = st.human_specility,
                human_telephone = st.human_telephone,
                attachment_name = st.attachment_name,
                checker = st.checker,
                check_status = st.check_status,
                check_time = st.check_time,
                pass_checkComment = st.pass_checkComment,
                pass_checker = st.pass_checker,
                pass_check_status = st.pass_check_status,
                pass_check_time = st.pass_check_time,
                pass_passComment = st.pass_passComment,
                pass_register = st.pass_register,
                pass_regist_time = st.pass_regist_time,
                total_points = st.total_points,
                test_amount = st.test_amount,
                test_checker = st.test_checker,
                test_check_time = st.test_check_time,
                engage_type = st.engage_type,
                demand_salary_standard = st.demand_salary_standard,
                interview_status = st.interview_status,
                recomandation = st.recomandation,
                register = st.register,
                regist_time = st.regist_time,
                remark = st.remark
            };
            return Add(est);
        }

        public int TKDel(engage_resumeModel st)
        {
            engage_resume est = new engage_resume()
            {
                res_id = st.res_id,
            };
            return Delete(est);
        }

        public List<engage_resumeModel> TKSelect()
        {
            List<engage_resume> list = SelectAll();
            List<engage_resumeModel> list2 = new List<engage_resumeModel>();
            foreach (engage_resume item in list)
            {
                engage_resumeModel sm = new engage_resumeModel()
                {
                    res_id = item.res_id,
                    human_address = item.human_address,
                    human_age = item.human_age,
                    human_birthday = item.human_birthday,
                    human_birthplace = item.human_birthplace,
                    human_college = item.human_college,
                    human_educated_degree = item.human_educated_degree,
                    human_educated_major = item.human_educated_major,
                    human_educated_years = item.human_educated_years,
                    human_email = item.human_email,
                    human_history_records = item.human_history_records,
                    human_hobby = item.human_hobby,
                    human_homephone = item.human_homephone,
                    human_idcard = item.human_idcard,
                    human_major_id = item.human_major_id,
                    human_major_kind_id = item.human_major_kind_id,
                    human_major_kind_name = item.human_major_kind_name,
                    human_mobilephonej = item.human_mobilephonej,
                    human_major_name = item.human_major_name,
                    human_name = item.human_name,
                    human_nationality = item.human_nationality,
                    human_party = item.human_party,
                    human_picture = item.human_picture,
                    human_postcode = item.human_postcode,
                    human_race = item.human_race,
                    human_religion = item.human_religion,
                    human_sex = item.human_sex,
                    human_specility = item.human_specility,
                    human_telephone = item.human_telephone,
                    attachment_name = item.attachment_name,
                    checker = item.checker,
                    check_status = item.check_status,
                    check_time = item.check_time,
                    pass_checkComment = item.pass_checkComment,
                    pass_checker = item.pass_checker,
                    pass_check_status = item.pass_check_status,
                    pass_check_time = item.pass_check_time,
                    pass_passComment = item.pass_passComment,
                    pass_register = item.pass_register,
                    pass_regist_time = item.pass_regist_time,
                    total_points = item.total_points,
                    test_amount = item.test_amount,
                    test_checker = item.test_checker,
                    test_check_time = item.test_check_time,
                    engage_type = item.engage_type,
                    demand_salary_standard = item.demand_salary_standard,
                    interview_status = item.interview_status,
                    recomandation = item.recomandation,
                    register = item.register,
                    regist_time = item.regist_time,
                    remark = item.remark
                };
                list2.Add(sm);
            }
            return list2;
        }

        public int TKUpdate(engage_resumeModel st)
        {
            engage_resume est = new engage_resume()
            {
                res_id = st.res_id,
                human_address = st.human_address,
                human_age = st.human_age,
                human_birthday = st.human_birthday,
                human_birthplace = st.human_birthplace,
                human_college = st.human_college,
                human_educated_degree = st.human_educated_degree,
                human_educated_major = st.human_educated_major,
                human_educated_years = st.human_educated_years,
                human_email = st.human_email,
                human_history_records = st.human_history_records,
                human_hobby = st.human_hobby,
                human_homephone = st.human_homephone,
                human_idcard = st.human_idcard,
                human_major_id = st.human_major_id,
                human_major_kind_id = st.human_major_kind_id,
                human_major_kind_name = st.human_major_kind_name,
                human_mobilephonej = st.human_mobilephonej,
                human_major_name = st.human_major_name,
                human_name = st.human_name,
                human_nationality = st.human_nationality,
                human_party = st.human_party,
                human_picture = st.human_picture,
                human_postcode = st.human_postcode,
                human_race = st.human_race,
                human_religion = st.human_religion,
                human_sex = st.human_sex,
                human_specility = st.human_specility,
                human_telephone = st.human_telephone,
                attachment_name = st.attachment_name,
                checker = st.checker,
                check_status = st.check_status,
                check_time = st.check_time,
                pass_checkComment = st.pass_checkComment,
                pass_checker = st.pass_checker,
                pass_check_status = st.pass_check_status,
                pass_check_time = st.pass_check_time,
                pass_passComment = st.pass_passComment,
                pass_register = st.pass_register,
                pass_regist_time = st.pass_regist_time,
                total_points = st.total_points,
                test_amount = st.test_amount,
                test_checker = st.test_checker,
                test_check_time = st.test_check_time,
                engage_type = st.engage_type,
                demand_salary_standard = st.demand_salary_standard,
                interview_status = st.interview_status,
                recomandation = st.recomandation,
                register = st.register,
                regist_time = st.regist_time,
                remark = st.remark
            };
            return Update(est);
        }

        public List<engage_resumeModel> SelectBy(engage_resumeModel st)
        {
            List<engage_resume> list = SelectBy(e => e.res_id.Equals(st.res_id));
            List<engage_resumeModel> list2 = new List<engage_resumeModel>();
            foreach (engage_resume item in list)
            {
                engage_resumeModel sm = new engage_resumeModel()
                {
                    res_id = list[0].res_id,
                    human_address = list[0].human_address,
                    human_age = list[0].human_age,
                    human_birthday = list[0].human_birthday,
                    human_birthplace = list[0].human_birthplace,
                    human_college = list[0].human_college,
                    human_educated_degree = list[0].human_educated_degree,
                    human_educated_major = list[0].human_educated_major,
                    human_educated_years = list[0].human_educated_years,
                    human_email = list[0].human_email,
                    human_history_records = list[0].human_history_records,
                    human_hobby = list[0].human_hobby,
                    human_homephone = list[0].human_homephone,
                    human_idcard = list[0].human_idcard,
                    human_major_id = list[0].human_major_id,
                    human_major_kind_id = list[0].human_major_kind_id,
                    human_major_kind_name = list[0].human_major_kind_name,
                    human_mobilephonej = list[0].human_mobilephonej,
                    human_major_name = list[0].human_major_name,
                    human_name = list[0].human_name,
                    human_nationality = list[0].human_nationality,
                    human_party = list[0].human_party,
                    human_picture = list[0].human_picture,
                    human_postcode = list[0].human_postcode,
                    human_race = list[0].human_race,
                    human_religion = list[0].human_religion,
                    human_sex = list[0].human_sex,
                    human_specility = list[0].human_specility,
                    human_telephone = list[0].human_telephone,
                    attachment_name = list[0].attachment_name,
                    checker = list[0].checker,
                    check_status = list[0].check_status,
                    check_time = list[0].check_time,
                    pass_checkComment = list[0].pass_checkComment,
                    pass_checker = list[0].pass_checker,
                    pass_check_status = list[0].pass_check_status,
                    pass_check_time = list[0].pass_check_time,
                    pass_passComment = list[0].pass_passComment,
                    pass_register = list[0].pass_register,
                    pass_regist_time = list[0].pass_regist_time,
                    total_points = list[0].total_points,
                    test_amount = list[0].test_amount,
                    test_checker = list[0].test_checker,
                    test_check_time = list[0].test_check_time,
                    engage_type = list[0].engage_type,
                    demand_salary_standard = list[0].demand_salary_standard,
                    interview_status = list[0].interview_status,
                    recomandation = list[0].recomandation,
                    register = list[0].register,
                    regist_time = list[0].regist_time,
                    remark = list[0].remark
                };
                list2.Add(sm);
            }
            return list2;
        }

        public DataTable SelectType()
        {
            string sql = "select * from config_major_kind";
            return DBHelper.SelectTable(sql);
        }

        public DataTable SelectType2(int id)
        {
            string sql = $"select major_id,major_name from config_major where major_kind_id = '{id}'";
            return DBHelper.SelectTable(sql);
        }
    }
}
